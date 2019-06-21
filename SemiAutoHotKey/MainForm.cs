using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using Keystroke.API;
using WindowsInput;
using WindowsInput.Native;

namespace SemiAutoHotKey
{
    public partial class MainForm : Form
    {
        private KeystrokeAPI keylogger = new KeystrokeAPI();
        private InputSimulator inputSim = new InputSimulator();
        private Keyboard hardwareInputSim = new Keyboard();
        private System.Timers.Timer timer = new System.Timers.Timer();
        private bool isSettingControl = false;
        private Keystroke.API.CallbackObjects.KeyPressed controlKey = null; // (not ctrl on your keyboard, dummy, the control to toggle stuff)
        private bool isActive = false;

        private class TimelineItem
        {
            public string name;
            public Func<bool> func; // return true = success, return false = something went wrong

            public TimelineItem()
            { }

            public TimelineItem(string name, Func<bool> func)
            {
                this.name = name;
                this.func = func;
            }

            public override string ToString()
            {
                return this.name;
            }
        }

        private enum InputType
        {
            KeyCode,
            Mouse,
            String,
            Delay
        }

        private enum KeyPressType
        {
            Down,
            Up,
            Press // AKA two-in-one
        }

        private enum MouseClickType
        {
            None,
            LeftDown,
            LeftUp,
            LeftClick,
            LeftDoubleClick,
            RightDown,
            RightUp,
            RightClick,
            RightDoubleClick,
            MiddleDown,
            MiddleUp,
            MiddleClick,
            MiddleDoubleClick,
            XDown,
            XUp,
            XClick,
            XDoubleClick
        }

        public MainForm()
        {
            InitializeComponent();

            InitKeylogger();
            InitTimer();
            InitInputTabs();

            Console.WriteLine("Finished initialising");
        }

        private void InitKeylogger()
        {
            keylogger.CreateKeyboardHook((character) =>
            {
                if(isSettingControl)
                {
                    if(character.KeyCode == KeyCode.Escape)
                    {
                        // Cancel trying to set the new control and reset it
                        controlKey = null;
                        ControlButton.Text = "Click to Set";
                        isSettingControl = false;
                        return;
                    }
                    controlKey = character;
                    ControlButton.Text = (controlKey.ToString() == " " ? "<space>" : controlKey.ToString());
                    isSettingControl = false;
                }
                else if(controlKey != null && character.ToString() == controlKey.ToString())
                {
                    toggleActive();
                }
            });
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            isSettingControl = !isSettingControl;
            if (isSettingControl)
            {
                ControlButton.Text = "Press key...";
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // To prevent the pressing of "enter" or "space" to re-execute the button
            if(ActiveControl == ControlButton /*&& (keyData == Keys.Enter || keyData == Keys.Return || keyData == Keys.Space)*/)
            {
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void toggleActive()
        {
            isActive = !isActive;
            AddInputButton.Enabled = !isActive;
            UpTimelineButton.Enabled = !isActive;
            DownTimelineButton.Enabled = !isActive;
            RemoveTimelineButton.Enabled = !isActive;
            IntervalInput.Enabled = !isActive;

            if (isActive)
            {
                timer.Interval = (int)IntervalInput.Value;
                timer.Start();

                StatusLabel.Text = "Active!";
            }
            else
            {
                timer.Stop();

                StatusLabel.Text = "Inactive";
            }

        }

        private void InitTimer()
        {
            timer.AutoReset = true;
            timer.Elapsed += (Object source, ElapsedEventArgs e) => {
                foreach(TimelineItem item in TimelineList.Items)
                {
                    bool result = item.func();
                    if(result)
                    {
                        Console.WriteLine("Successfully executed " + item.name);
                    }
                }
            };
        }

        private void InitInputTabs()
        {
            // This method just initialises the values that can be selected, not the logic.
            // Logic occurs when "Add" is clicked

            // KeyCode tab
            foreach(VirtualKeyCode virtualKeyCode in Enum.GetValues(typeof(VirtualKeyCode)))
            {
                KeyCodeTabCombo.Items.Add(virtualKeyCode); // Enums have a ToString() method so it's all good
            }
            foreach(Keyboard.ScanCodeShort scanCode in Enum.GetValues(typeof(Keyboard.ScanCodeShort)))
            {
                HardwareKeyCodeTabCombo.Items.Add(scanCode);
            }

            // Mouse tab
            foreach(MouseClickType mouseClickType in Enum.GetValues(typeof(MouseClickType)))
            {
                MouseClickMouseTabCombo.Items.Add(mouseClickType);
            }
            MouseClickMouseTabCombo.SelectedItem = MouseClickType.None;

            // String tab
            // Nothing

            // Delay tab
            // Nothing
        }

        private void AddInputButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<TimelineItem> tempItems = new List<TimelineItem>(); // it's a list because sometimes we need to add two events
                tempItems.Add(new TimelineItem()); // there will always be one event added

                InputType tabType = (InputType)Enum.Parse(typeof(InputType), InputTypeTabs.SelectedTab.Text, true);

                switch (tabType)
                {
                    case InputType.KeyCode:
                        if(!HardwareKeyCodeTabCheck.Checked)
                        {
                            VirtualKeyCode virtualKeyCode = (VirtualKeyCode)KeyCodeTabCombo.SelectedItem;

                            if (SplitKeyCodeTabCheck.Checked)
                            {
                                tempItems[0].name = tabType.ToString() + " - Pressed Down " + virtualKeyCode.ToString();
                                tempItems[0].func = createKeyCodeFunc(KeyPressType.Down, virtualKeyCode);

                                tempItems.Add(new TimelineItem());
                                tempItems[1].name = tabType.ToString() + " - Pressed Up " + virtualKeyCode.ToString();
                                tempItems[1].func = createKeyCodeFunc(KeyPressType.Up, virtualKeyCode);
                            }
                            else // We just do a regular keypress
                            {
                                tempItems[0].name = tabType.ToString() + " - Pressed Down & Up " + virtualKeyCode.ToString();
                                tempItems[0].func = createKeyCodeFunc(KeyPressType.Press, virtualKeyCode);
                            }
                        }
                        else // use hardware key input instead
                        {
                            Keyboard.ScanCodeShort scanCode = (Keyboard.ScanCodeShort)HardwareKeyCodeTabCombo.SelectedItem;

                            tempItems[0].name = tabType.ToString() + " - Hardware input " + scanCode.ToString();
                            tempItems[0].func = createHardwareKeyCodeFunc(scanCode);
                        }
                        break;
                    case InputType.Mouse:
                        int moveX = (int)MoveXMouseTabInput.Value;
                        int moveY = (int)MoveYMouseTabInput.Value;
                        bool moveAbsolute = AbsoluteMouseTabCheck.Checked;
                        int scrollHor = (int)ScrollHorMouseTabInput.Value;
                        int scrollVert = (int)ScrollVertMouseTabInput.Value;
                        MouseClickType mouseClickType = (MouseClickType)MouseClickMouseTabCombo.SelectedItem;
                        int xID = (int)XIDMouseTabInput.Value;

                        tempItems[0].name = tabType.ToString() + " - ";
                        if(moveX != 0 || moveY != 0 || moveAbsolute)
                        {
                            tempItems[0].name += "Move " + (moveAbsolute? "to " : "by ") + moveX + "," + moveY + " ";
                        }
                        if(scrollHor != 0 || scrollVert != 0)
                        {
                            tempItems[0].name += "Scroll by " + scrollHor + "," + scrollVert + " ";
                        }
                        if(mouseClickType != MouseClickType.None)
                        {
                            tempItems[0].name += mouseClickType.ToString() + " ";
                            if(mouseClickType.ToString().Contains("X"))
                            {
                                tempItems[0].name += "button ID " + xID + " ";
                            }
                        }
                        if(moveX == 0 && moveY == 0 && !moveAbsolute && scrollHor == 0 && scrollVert == 0 && mouseClickType == MouseClickType.None)
                        {
                            throw new Exception("No mouse input configuration was made");
                        }

                        tempItems[0].func = createMouseFunc(moveX, moveY, moveAbsolute, scrollHor, scrollVert, mouseClickType, xID);
                        break;
                    case InputType.String:
                        string message = StringTabInput.Text;
                        if(message.Length > 1000)
                        {
                            throw new Exception("String message too long");
                        }
                        tempItems[0].name = tabType.ToString() + " - \"" + message + "\"";
                        tempItems[0].func = createStringFunc(message);
                        break;
                    case InputType.Delay:
                        int delay = (int)DelayTabInput.Value;
                        tempItems[0].name = tabType.ToString() + " - " + delay + "ms";
                        tempItems[0].func = createDelayFunc(delay);
                        break;
                    default:
                        throw new Exception("Somehow, no input type tab was selected.");
                }

                TimelineList.Items.AddRange(tempItems.ToArray());
            }
            catch (Exception err)
            {
                Console.WriteLine("Error occurred when trying to add new input to timeline: {0}", err.Message);
            }
        }

        private Func<bool> createKeyCodeFunc(KeyPressType keyPressType, VirtualKeyCode virtualKeyCode)
        {
            Func<bool> result = () => {
                return false;
            };

            if(keyPressType == KeyPressType.Down)
            {
                result = () =>
                {
                    inputSim.Keyboard.KeyDown(virtualKeyCode);
                    return true;
                };
            }
            else if(keyPressType == KeyPressType.Up)
            {
                result = () =>
                {
                    inputSim.Keyboard.KeyUp(virtualKeyCode);
                    return true;
                };
            }
            else if(keyPressType == KeyPressType.Press)
            {
                result = () =>
                {
                    inputSim.Keyboard.KeyPress(virtualKeyCode);
                    return true;
                };
            }
            return result;
        }

        private Func<bool> createHardwareKeyCodeFunc(Keyboard.ScanCodeShort scanCode)
        {
            return () =>
            {
                hardwareInputSim.Send(scanCode);
                return true;
            };
        }

        private Func<bool> createMouseFunc(int moveX, int moveY, bool moveAbsolute, int scrollHor, int scrollVert, MouseClickType mouseClickType, int xID)
        {
            Func<bool> result = () => {
                if (moveAbsolute)
                {
                    Cursor.Position = new Point(moveX, moveY);
                }
                else if(moveX != 0 || moveY != 0)
                {
                    Point curPos = Cursor.Position;
                    Cursor.Position = new Point(curPos.X + moveX, curPos.Y + moveY);
                }
                if (scrollHor != 0)
                {
                    inputSim.Mouse.HorizontalScroll(scrollHor);
                }
                if(scrollVert != 0)
                {
                    inputSim.Mouse.VerticalScroll(scrollVert);
                }
                switch(mouseClickType)
                {
                    case MouseClickType.None:
                        break;
                    case MouseClickType.LeftDown:
                        inputSim.Mouse.LeftButtonDown();
                        break;
                    case MouseClickType.LeftUp:
                        inputSim.Mouse.LeftButtonUp();
                        break;
                    case MouseClickType.LeftClick:
                        inputSim.Mouse.LeftButtonClick();
                        break;
                    case MouseClickType.LeftDoubleClick:
                        inputSim.Mouse.LeftButtonDoubleClick();
                        break;
                    case MouseClickType.RightDown:
                        inputSim.Mouse.RightButtonDown();
                        break;
                    case MouseClickType.RightUp:
                        inputSim.Mouse.RightButtonUp();
                        break;
                    case MouseClickType.RightClick:
                        inputSim.Mouse.RightButtonClick();
                        break;
                    case MouseClickType.RightDoubleClick:
                        inputSim.Mouse.RightButtonDoubleClick();
                        break;
                    case MouseClickType.XDown:
                        inputSim.Mouse.XButtonDown(xID);
                        break;
                    case MouseClickType.XUp:
                        inputSim.Mouse.XButtonUp(xID);
                        break;
                    case MouseClickType.XClick:
                        inputSim.Mouse.XButtonClick(xID);
                        break;
                    case MouseClickType.XDoubleClick:
                        inputSim.Mouse.XButtonDoubleClick(xID);
                        break;
                }
                return true;
            };
            return result;
        }

        private Func<bool> createStringFunc(string message)
        {
            Func<bool> result = () => {
                inputSim.Keyboard.TextEntry(message);
                return true;
            };
            return result;
        }

        private Func<bool> createDelayFunc(int delay)
        {
            Func<bool> result = () => {
                Thread.Sleep(delay);
                return true;
            };
            return result;
        }

        private void UpTimelineButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = TimelineList.SelectedIndex;
            if(selectedIndex == 0 || selectedIndex == -1)
            {
                return;
            }
            TimelineItem prevItemAbove = (TimelineItem)TimelineList.Items[selectedIndex - 1];
            TimelineList.Items[selectedIndex - 1] = TimelineList.SelectedItem;
            TimelineList.Items[selectedIndex] = prevItemAbove;
            TimelineList.SelectedIndex = selectedIndex - 1;
        }

        private void DownTimelineButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = TimelineList.SelectedIndex;
            if (selectedIndex == TimelineList.Items.Count-1 || selectedIndex == -1)
            {
                return;
            }
            TimelineItem prevItemBelow = (TimelineItem)TimelineList.Items[selectedIndex + 1];
            TimelineList.Items[selectedIndex + 1] = TimelineList.SelectedItem;
            TimelineList.Items[selectedIndex] = prevItemBelow;
            TimelineList.SelectedIndex = selectedIndex + 1;
        }

        private void RemoveTimelineButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = TimelineList.SelectedIndex;
            if(selectedIndex == -1) // default if items is unpopulated
            {
                return;
            }
            TimelineList.Items.RemoveAt(selectedIndex);
            if(TimelineList.Items.Count == 0)
            {
                TimelineList.SelectedIndex = -1;
            }
            else if(selectedIndex == TimelineList.Items.Count)
            {
                TimelineList.SelectedIndex = selectedIndex - 1;
            }
            else
            {
                TimelineList.SelectedIndex = selectedIndex;
            }
        }

        private void HardwareKeyCodeTabCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = HardwareKeyCodeTabCheck.Checked;
            HardwareKeyCodeTabCombo.Enabled = isChecked;
            KeyCodeTabCombo.Enabled = !isChecked;
            SplitKeyCodeTabCheck.Enabled = !isChecked;
        }
    }
}

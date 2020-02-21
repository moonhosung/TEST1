
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
//using V_VISIONPRO;

namespace TEST1.Function
{
    public class CUIInvoke
    {
        private static CUIInvoke theInstance = null;
        public static CUIInvoke CreateInstance()
        {
            if (theInstance == null)
            {
                theInstance = new CUIInvoke();
            }
            return theInstance;
        }
        public static CUIInvoke GetInstance()
        {
            return theInstance;
        }

        delegate void Ctr_InvolkTextControl(Control ctr, string text);
        public void SetTextControl(Control ctr, string text)
        {
            if (ctr.InvokeRequired)
            {
                Ctr_InvolkTextControl CI = new Ctr_InvolkTextControl(SetTextControl);
                ctr.Invoke(CI, ctr, text);
            }
            else
            {
                ctr.Text = text;
            }
        }

        delegate void Ctr_InvolkVisible(Form ctr, bool visible);
        public void InvolkVisible(Form ctr, bool visible)
        {
            if (ctr.InvokeRequired)
            {
                Ctr_InvolkVisible CI = new Ctr_InvolkVisible(InvolkVisible);
                ctr.Invoke(CI, ctr, visible);
            }
            else
            {
                ctr.Visible = visible;
            }
        }



        delegate void Ctr_InvolkListBox(ListBox ctr, string text);
        public void SetTextListControl(ListBox ctr, string text)
        {
            if (ctr.InvokeRequired)
            {
                Ctr_InvolkListBox CI = new Ctr_InvolkListBox(SetTextListControl);
                ctr.Invoke(CI, ctr, text);
            }
            else
            {
                ctr.Items.Add(text);
                ctr.Text = text;
            }
        }

        delegate void Ctr_InvolkButtonBackGroundText(Button ctr, Image image, string text);
        public void SetInvokButtonBackGroundText(Button ctr, Image image, string text)
        {
            if (ctr.InvokeRequired)
            {
                Ctr_InvolkButtonBackGroundText CI = new Ctr_InvolkButtonBackGroundText(SetInvokButtonBackGroundText);
                ctr.Invoke(CI, ctr, image, text);
            }
            else
            {
                ctr.Text = text;
                ctr.BackgroundImage = image;
                ctr.Invalidate();
            }
        }




        delegate void Ctr_InvolkOpacity(Form ctr, double Opacity);
        public void SetInvolkOpacity(Form ctr, double Opacity)
        {
            if (ctr.InvokeRequired)
            {
                Ctr_InvolkOpacity CI = new Ctr_InvolkOpacity(SetInvolkOpacity);
                ctr.Invoke(CI, ctr, Opacity);
            }
            else
            {
                ctr.Opacity = Opacity;
            }
        }

        delegate void Ctr_InvolkHide(Form ctr);
        public void SetInvolkHide(Form ctr)
        {
            if (ctr.InvokeRequired)
            {
                Ctr_InvolkHide CI = new Ctr_InvolkHide(SetInvolkHide);
                ctr.Invoke(CI, ctr);
            }
            else
            {
                ctr.Hide();
            }
        }
        delegate void Ctr_ToolStripButtonEnable(System.Windows.Forms.ToolStrip ctr, int index, bool bEnable);
        public void SetToolStripButtonEnable(System.Windows.Forms.ToolStrip ctr, int index, bool bEnable)
        {
            if (ctr.InvokeRequired)
            {

                Ctr_ToolStripButtonEnable CI = new Ctr_ToolStripButtonEnable(SetToolStripButtonEnable);
                ctr.Invoke(CI, ctr, index, bEnable);
            }
            else
            {
                ctr.Items[index].Enabled = bEnable;
            }
        }


        delegate void Ctr_ToolStripButtonChecked(System.Windows.Forms.ToolStrip ctr, int index, bool bCheck);
        public void SetToolStripButtonCheked(System.Windows.Forms.ToolStrip ctr, int index, bool bCheck)
        {
            if (ctr.InvokeRequired)
            {

                Ctr_ToolStripButtonChecked CI = new Ctr_ToolStripButtonChecked(SetToolStripButtonCheked);
                ctr.Invoke(CI, ctr, index, bCheck);
            }
            else
            {
                if (bCheck == true)
                {
                    ((ToolStripButton)ctr.Items[index]).BackColor = Color.Aquamarine;
                    //((ToolStripButton)ctr.Items[index]).Checked = true;
                }
                else
                {
                    //((ToolStripButton)ctr.Items[index]).Checked = false;
                    ((ToolStripButton)ctr.Items[index]).BackColor = Color.LightSteelBlue;
                }
            }
        }

        delegate void Ctr_ToolStripButtonImage(System.Windows.Forms.ToolStrip ctr, int index, Bitmap image);
        public void SetToolStripButtonImage(System.Windows.Forms.ToolStrip ctr, int index, Bitmap image)
        {
            if (ctr.InvokeRequired)
            {

                Ctr_ToolStripButtonImage CI = new Ctr_ToolStripButtonImage(SetToolStripButtonImage);
                ctr.Invoke(CI, ctr, index, image);
            }
            else
            {
                ((ToolStripButton)ctr.Items[index]).Image = image;
            }
        }

        delegate void Ctr_ToolStripDropDownButtonChecked(System.Windows.Forms.ToolStrip ctr, int index, bool bCheck);
        public void SetToolStripDropDownButtonChecked(System.Windows.Forms.ToolStrip ctr, int index, bool bCheck)
        {
            if (ctr.InvokeRequired)
            {
                Ctr_ToolStripDropDownButtonChecked CI = new Ctr_ToolStripDropDownButtonChecked(SetToolStripDropDownButtonChecked);
                ctr.Invoke(CI, ctr, index, bCheck);
            }
            else
            {
                // ((ToolStripDropDownButton)ctr.Items[index]).Checked = bCheck;
            }
        }

        delegate void Ctr_ToolStripLabelChecked(System.Windows.Forms.ToolStrip ctr, int index, string strText);
        public void SetToolStripLabelText(System.Windows.Forms.ToolStrip ctr, int index, string strText)
        {
            if (ctr.InvokeRequired)
            {

                Ctr_ToolStripLabelChecked CI = new Ctr_ToolStripLabelChecked(SetToolStripLabelText);
                ctr.Invoke(CI, ctr, index, strText);
            }
            else
            {
                ((ToolStripLabel)ctr.Items[index]).Text = strText;
            }
        }
        #region // Function - UI Invoke
     
        delegate void Ctr_InvokeGroupBoxEnable(System.Windows.Forms.GroupBox ctr, bool bEnable);
        public void InvokeGroupBoxEnable(System.Windows.Forms.GroupBox ctr, bool bEnable)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeGroupBoxEnable CI = new Ctr_InvokeGroupBoxEnable(InvokeGroupBoxEnable);
                    ctr.Invoke(CI, ctr, bEnable);
                }
                else
                {
                    if (bEnable)
                    {
                        ctr.Visible = true;
                        ctr.Enabled = true;
                    }
                    else
                    {
                        ctr.Visible = false;
                        ctr.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }


        delegate void Ctr_InvokeTextBox(Control ctr, string text);
        public void InvokeTextBox(Control ctr, string text)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeTextBox CI = new Ctr_InvokeTextBox(InvokeTextBox);
                    ctr.Invoke(CI, ctr, text);
                }
                else
                {
                    ctr.Text = text;
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        delegate void Ctr_InvokeSpinControl(System.Windows.Forms.NumericUpDown ctr, int iValue);
        public void InvokeSpinControl(System.Windows.Forms.NumericUpDown ctr, int iValue)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeSpinControl CI = new Ctr_InvokeSpinControl(InvokeSpinControl);
                    ctr.Invoke(CI, ctr, iValue);
                }
                else
                {
                    ctr.Value = iValue;
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        delegate void Ctr_InvokeRadioButton(System.Windows.Forms.RadioButton ctr, bool Value);
        public void InvokeRadioButton(System.Windows.Forms.RadioButton ctr, bool Value)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeRadioButton CI = new Ctr_InvokeRadioButton(InvokeRadioButton);
                    ctr.Invoke(CI, ctr, Value);
                }
                else
                {
                    ctr.Checked = Value;
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        delegate void Ctr_InvokeLabel(System.Windows.Forms.Label ctr, System.Drawing.Color foreColor, System.Drawing.Color backColor, string strText);
        public void InvokeLabel(System.Windows.Forms.Label ctr, System.Drawing.Color foreColor, System.Drawing.Color backColor, string strText)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeLabel CI = new Ctr_InvokeLabel(InvokeLabel);
                    ctr.Invoke(CI, ctr, foreColor, backColor, strText);
                }
                else
                {
                    ctr.ForeColor = foreColor;
                    ctr.BackColor = backColor;
                    ctr.Text = strText;
                    ctr.Invalidate();
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }


        delegate void Ctr_InvokeDataGridAddRow(System.Windows.Forms.DataGridView ctr, string[] row);
        public void InvokeDataGridAddRow(System.Windows.Forms.DataGridView ctr, string[] row)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeDataGridAddRow CI = new Ctr_InvokeDataGridAddRow(InvokeDataGridAddRow);
                    ctr.Invoke(CI, ctr, row);
                }
                else
                {
                    ctr.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        delegate void Ctr_InvokeDataGridAddNumber(System.Windows.Forms.DataGridView ctr);
        public void InvokeDataGridAddNumber(System.Windows.Forms.DataGridView ctr)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeDataGridAddNumber CI = new Ctr_InvokeDataGridAddNumber(InvokeDataGridAddNumber);
                    ctr.Invoke(CI, ctr);
                }
                else
                {
                    foreach (DataGridViewRow row in ctr.Rows)
                    {
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                    }
                    ctr.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        delegate void Ctr_InvokeDataGridClear(System.Windows.Forms.DataGridView ctr);
        public void InvokeDataGridClear(System.Windows.Forms.DataGridView ctr)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeDataGridClear CI = new Ctr_InvokeDataGridClear(InvokeDataGridClear);
                    ctr.Invoke(CI, ctr);
                }
                else
                {
                    ctr.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }


        delegate void Ctr_InvokeDataGridSetNumber(System.Windows.Forms.DataGridView ctr);
        public void InvokeDataGridSetNumber(System.Windows.Forms.DataGridView ctr)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeDataGridSetNumber CI = new Ctr_InvokeDataGridSetNumber(InvokeDataGridSetNumber);
                    ctr.Invoke(CI, ctr);
                }
                else
                {
                    foreach (DataGridViewRow row in ctr.Rows)
                    {
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                    }
                    ctr.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }
        delegate void Ctr_InvokeUpdateSelectedRow(System.Windows.Forms.DataGridView ctr, int iRowIndex);
        public void InvokeUpdateSelectedRow(System.Windows.Forms.DataGridView ctr, int iRowIndex)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeUpdateSelectedRow CI = new Ctr_InvokeUpdateSelectedRow(InvokeUpdateSelectedRow);
                    ctr.Invoke(CI, ctr, iRowIndex);
                }
                else
                {
                    ctr.CurrentCell = ctr.Rows[iRowIndex].Cells[0];
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }


        delegate void Ctr_InvokePanelImage(Panel ctr, Bitmap image);
        public void InvokePanelImage(Panel ctr, Bitmap image)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokePanelImage CI = new Ctr_InvokePanelImage(InvokePanelImage);
                    ctr.Invoke(CI, ctr, image);
                }
                else
                {
                    ctr.BackgroundImage = image;
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        delegate void Ctr_InvokePictureBox(PictureBox ctr, Image image);
        public void InvokePictureBox(PictureBox ctr, Image image)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokePictureBox CI = new Ctr_InvokePictureBox(InvokePictureBox);
                    ctr.Invoke(CI, ctr, image);
                }
                else
                {
                    ctr.BackgroundImage = image;
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }
        //delegate void Ctr_InvokeNull(PictureBox ctr);
        //public void InvokeNull(PictureBox ctr)
        //{
        //    try
        //    {
        //        if (ctr.InvokeRequired)
        //        {
        //            Ctr_InvokeNull CI = new Ctr_InvokeNull(InvokeNull);
        //            ctr.Invoke(CI, ctr);
        //        }
        //        else
        //        {
        //            ctr.Image = null;
        //            ctr.BackgroundImage = Properties.Resources.NO_IMG;
        //            ctr.Invalidate();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
        //    }
        //}


        delegate void Ctr_InvokePictureBoxSize(PictureBox ctr, int width, int height);
        public void InvokePictureBoxSize(PictureBox ctr, int width, int height)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokePictureBoxSize CI = new Ctr_InvokePictureBoxSize(InvokePictureBoxSize);
                    ctr.Invoke(CI, ctr, width, height);
                }
                else
                {
                    ctr.Width = width;
                    ctr.Height = height;
                    ctr.Invalidate();
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        delegate void Ctr_InvokePanel(Panel ctr);
        public void InvokePanel(Panel ctr)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokePanel CI = new Ctr_InvokePanel(InvokePanel);
                    ctr.Invoke(CI, ctr);
                }
                else
                {
                    ctr.Invalidate();
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }


        delegate void Ctr_InvokeFormShowDlg(Form ctr, bool bShow, bool modal);
        public void InvokeFormShowDlg(Form ctr, bool bShow, bool modal)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeFormShowDlg CI = new Ctr_InvokeFormShowDlg(InvokeFormShowDlg);
                    ctr.Invoke(CI, ctr, bShow, modal);
                }
                else
                {
                    if (bShow)
                    {
                        ctr.TopLevel = true;
                        ctr.TopMost = true;
                        if (modal)
                        {
                            ctr.ShowDialog();
                        }
                        else
                        {
                            ctr.Show();
                        }
                    }
                    else
                    {
                        ctr.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }



        delegate void Ctr_InvokeFormTop(Form ctr);
        public void InvokeFormTop(Form ctr)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeFormTop CI = new Ctr_InvokeFormTop(InvokeFormTop);
                    ctr.Invoke(CI, ctr);
                }
                else
                {

                    ctr.TopLevel = true;
                    ctr.TopMost = true;
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        delegate void Ctr_InvokeFormHideDlg(Form ctr);
        public void InvokeFormHideDlg(Form ctr)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeFormHideDlg CI = new Ctr_InvokeFormHideDlg(InvokeFormHideDlg);
                    ctr.Invoke(CI, ctr);
                }
                else
                {
                    ctr.Hide();
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        delegate void Ctr_InvolkCheckBox(Control ctr, string text);
        public void SetCheckBoxTextControl(Control ctr, string text)
        {
            if (ctr.InvokeRequired)
            {
                Ctr_InvolkCheckBox CI = new Ctr_InvolkCheckBox(SetCheckBoxTextControl);
                ctr.Invoke(CI, ctr, text);
            }
            else
            {
                ctr.Text = text;
            }
        }
        #endregion 



        delegate void Ctr_InvolkSplitContainerShow(System.Windows.Forms.SplitContainer ctr, bool bShow);
        public void InvolkSplitContainerShow(System.Windows.Forms.SplitContainer ctr, bool bShow)
        {
            if (ctr.InvokeRequired)
            {
                Ctr_InvolkSplitContainerShow CI = new Ctr_InvolkSplitContainerShow(InvolkSplitContainerShow);
                ctr.Invoke(CI, ctr, bShow);
            }
            else
            {
                if (bShow == true)
                {
                    ctr.Show();
                }
                else
                {
                    ctr.Hide();
                }
            }
        }



        delegate void Ctr_ControlAdd(UserControl ctr, System.Windows.Forms.Form addControl);
        public void InvolkControlAdd(UserControl ctr, System.Windows.Forms.Form addControl)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_ControlAdd CI = new Ctr_ControlAdd(InvolkControlAdd);
                    ctr.Invoke(CI, ctr, addControl);
                }
                else
                {
                    ctr.Controls.Add(addControl);
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), 5);
            }
        }

        delegate void Ctr_InvolkControlRemove(UserControl ctr, System.Windows.Forms.Form addControl);
        public void InvolkControlRemove(UserControl ctr, System.Windows.Forms.Form addControl)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvolkControlRemove CI = new Ctr_InvolkControlRemove(InvolkControlRemove);
                    ctr.Invoke(CI, ctr, addControl);
                }
                else
                {
                    ctr.Controls.Remove(addControl);
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), 5);
            }
        }

        delegate void Ctr_InvolkSplitterControlAdd(SplitContainer ctr, UserControl addControl, int nPannelIndex);
        public void InvolkSplitterControlAdd(SplitContainer ctr, UserControl addControl, int nPannelIndex)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvolkSplitterControlAdd CI = new Ctr_InvolkSplitterControlAdd(InvolkSplitterControlAdd);
                    ctr.Invoke(CI, ctr, addControl, nPannelIndex);
                }
                else
                {
                    if (nPannelIndex == 1)
                    {
                        addControl.Dock = DockStyle.Fill;
                        ctr.Panel1.Controls.Add(addControl);
                    }
                    else if (nPannelIndex == 2)
                    {
                        addControl.Dock = DockStyle.Fill;
                        ctr.Panel2.Controls.Add(addControl);
                    }
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), 5);
            }
        }

        delegate void Ctr_InvolkSplitterControlRemove(SplitContainer ctr, UserControl addControl, int nPannelIndex);
        public void InvolkSplitterControlRemove(SplitContainer ctr, UserControl addControl, int nPannelIndex)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvolkSplitterControlRemove CI = new Ctr_InvolkSplitterControlRemove(InvolkSplitterControlRemove);
                    ctr.Invoke(CI, ctr, addControl, nPannelIndex);
                }
                else
                {
                    if (nPannelIndex == 1)
                    {
                        ctr.Panel1.Controls.Remove(addControl);
                    }
                    else if (nPannelIndex == 2)
                    {
                        ctr.Panel2.Controls.Remove(addControl);
                    }
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), 5);
            }
        }

        delegate void Ctr_InvolkUsercontrolShow(UserControl ctr);
        public void InvolkUsercontrolShow(UserControl ctr)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvolkUsercontrolShow CI = new Ctr_InvolkUsercontrolShow(InvolkUsercontrolShow);
                    ctr.Invoke(CI, ctr);
                }
                else
                {
                    ctr.Show();
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), 5);
            }
        }

        delegate void Ctr_InvolkUsercontrolHide(UserControl ctr);
        public void InvolkUsercontrolHide(UserControl ctr)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvolkUsercontrolHide CI = new Ctr_InvolkUsercontrolHide(InvolkUsercontrolHide);
                    ctr.Invoke(CI, ctr);
                }
                else
                {
                    ctr.Hide();
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), 5);
            }
        }

        delegate void Ctr_InvolkTopMostForm(System.Windows.Forms.Form ctr);
        public void InvokeTopMostForm(System.Windows.Forms.Form ctr)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvolkTopMostForm CI = new Ctr_InvolkTopMostForm(InvokeTopMostForm);
                    ctr.Invoke(CI, ctr);
                }
                else
                {
                    // We do not want anyone to see this window so position it off the visible screen and make it as small as possible
                    ctr.Size = new System.Drawing.Size(1, 1);
                    ctr.StartPosition = FormStartPosition.Manual;
                    System.Drawing.Rectangle rect = SystemInformation.VirtualScreen;
                    ctr.Location = new System.Drawing.Point(rect.Bottom + 10, rect.Right + 10);
                    ctr.Show();
                    // Make this form the active form and make it TopMost
                    ctr.Focus();
                    ctr.BringToFront();
                    ctr.TopMost = true;
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), 5);
            }
        }

        delegate void Ctr_InvokePictureBoxTop(PictureBox ctr, int top);
        public void InvokePictureBoxTop(PictureBox ctr, int top)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokePictureBoxTop CI = new Ctr_InvokePictureBoxTop(InvokePictureBoxTop);
                    ctr.Invoke(CI, ctr, top);
                }
                else
                {
                    ctr.Top = top;
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), 5);
            }
        }

        delegate void Ctr_InvokePictureBoxVisible(PictureBox ctr, bool visible);
        public void InvokePictureBoxVisible(PictureBox ctr, bool visible)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokePictureBoxVisible CI = new Ctr_InvokePictureBoxVisible(InvokePictureBoxVisible);
                    ctr.Invoke(CI, ctr, visible);
                }
                else
                {
                    ctr.Visible = visible;
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), 5);
            }
        }

        delegate void Ctr_InvorkFormShowTopMost(System.Windows.Forms.Form ctr);
        public void InvorkFormShowTopMost(System.Windows.Forms.Form ctr)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvorkFormShowTopMost CI = new Ctr_InvorkFormShowTopMost(InvorkFormShowTopMost);
                    ctr.Invoke(CI, ctr);
                }
                else
                {
                    ctr.Focus();
                    ctr.TopMost = false;
                    ctr.BringToFront();
                    ctr.TopMost = true;
                    ctr.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), 5);
            }
        }

        #region //ListView Control 
        delegate void Ctr_InvokeListViewBeginUpdate(System.Windows.Forms.ListView ctr);
        public void InvokeListViewBeginUpdate(System.Windows.Forms.ListView ctr)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeListViewBeginUpdate CI = new Ctr_InvokeListViewBeginUpdate(InvokeListViewBeginUpdate);
                    ctr.Invoke(CI, ctr);
                }
                else
                {
                    ctr.BeginUpdate();
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        delegate void Ctr_InvokeListViewEndUpdate(System.Windows.Forms.ListView ctr);
        public void InvokeListViewEndUpdate(System.Windows.Forms.ListView ctr)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeListViewEndUpdate CI = new Ctr_InvokeListViewEndUpdate(InvokeListViewEndUpdate);
                    ctr.Invoke(CI, ctr);
                }
                else
                {
                    ctr.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        delegate void Ctr_InvokeListViewAddItem(System.Windows.Forms.ListView ctr, string str);
        public void InvokeListViewAddItem(System.Windows.Forms.ListView ctr, string str)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeListViewAddItem CI = new Ctr_InvokeListViewAddItem(InvokeListViewAddItem);
                    ctr.Invoke(CI, ctr);
                }
                else
                {
                    ctr.Items.Add(str);
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        delegate void Ctr_InvokeListViewClear(System.Windows.Forms.ListView ctr);
        public void InvokeListViewClear(System.Windows.Forms.ListView ctr)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeListViewClear CI = new Ctr_InvokeListViewClear(InvokeListViewClear);
                    ctr.Invoke(CI, ctr);
                }
                else
                {
                    ctr.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        delegate void Ctr_InvokeListViewSetFocusItem(System.Windows.Forms.ListView ctr, int nSelectRow);
        public void InvokeListViewSetFocusItem(System.Windows.Forms.ListView ctr, int nSelectRow)
        {
            try
            {
                if (ctr.InvokeRequired)
                {
                    Ctr_InvokeListViewSetFocusItem CI = new Ctr_InvokeListViewSetFocusItem(InvokeListViewSetFocusItem);
                    ctr.Invoke(CI, ctr, nSelectRow);
                }
                else
                {
                    ctr.Items[nSelectRow].Selected = true;
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }
        #endregion

    }
}


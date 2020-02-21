using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;

/// <summary>
/// Log Handler Class
/// </summary>

namespace TEST1.Function
{
    public class CLog
    {
        public enum LogType
        {
            Process = 1,
            Inspection = 2,
            Alram = 3,
            Network = 4,
            Error = 5
        }

        private static Mutex mtx = new Mutex(false, "LogSave");

        /// <summary>
        /// Add Log Message in the ListBox
        /// </summary>
        public static void AddLogMessage(ListBox ctr, string msg, int selection)
        {
            try
            {
                mtx.WaitOne();
                string CurrentTime = DateTime.Now.ToString("DATE=[yyyy-MM-dd HH:mm:ss],");
                string strMsg = CurrentTime + msg;
                CUIInvoke uiInvoke = CUIInvoke.CreateInstance();

                //List창에 디스플레이 
                uiInvoke.SetTextListControl(ctr, strMsg);

                SaveLogFile(strMsg, selection);
                mtx.ReleaseMutex();
            }
            catch (System.Exception ex)
            {
                SaveLogFile(ex.ToString(), 4);
            }
        }

        /// <summary>
        /// Add Log Message in the ListBox
        /// </summary>

        public static void AddLogMessage(string msg, int selection)
        {
            try
            {
                mtx.WaitOne();
              //  Log logDlg = Log.CreateInstance();

                string CurrentTime = DateTime.Now.ToString("DATE=[yyyy-MM-dd HH:mm:ss],");
                string strMsg = CurrentTime + msg;
                CUIInvoke uiInvoke = CUIInvoke.CreateInstance();

                switch (selection)
                {
                    case (int)LogType.Process:
                        {
                            //      uiInvoke.SetTextListControl(logDlg.listBox_ProcessLog, strMsg);
                        }
                        break;
                    case (int)LogType.Inspection:
                        {
                            //   uiInvoke.SetTextListControl(logDlg.listBox_InspectionLog, strMsg);
                        }
                        break;
                    case (int)LogType.Alram:
                        {
                            //   uiInvoke.SetTextListControl(logDlg.listBox_AlramLog, strMsg);
                        }
                        break;
                    case (int)LogType.Network:
                        {
                            //   uiInvoke.SetTextListControl(logDlg.listBox_NetworkLog, strMsg);
                        }
                        break;
                }

                SaveLogFile(strMsg, selection);
                mtx.ReleaseMutex();
            }
            catch (System.Exception ex)
            {
                SaveLogFile(ex.ToString(), 4);
            }
        }

        /// <summary>
        /// Save Log Data 
        /// </summary>
        public static void SaveLogFile(string strMsg, int selection)
        {
            try
            {
                string strExePath = Directory.GetCurrentDirectory(); //실행
                string strFileName = null;
                string strFilePath = null;

                switch (selection)
                {
                    case (int)LogType.Process: //Process Log 
                        {
                            strFilePath = strExePath + "\\DATA\\LOG\\ProcessLog\\";
                            strFileName = strFilePath + "ProcessLog_" + DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + ".txt";
                            break;
                        }

                    case (int)LogType.Inspection: //Inspection Log
                        {
                            strFilePath = strExePath + "\\DATA\\LOG\\InspectionLog\\";
                            strFileName = strFilePath + "InspectionLog_" + DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + ".txt";
                            break;
                        }
                    case (int)LogType.Alram: //Alram Log
                        {
                            string CurrentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff ");
                            strMsg = CurrentTime + " " + strMsg;

                            strFilePath = strExePath + "\\DATA\\LOG\\AlramLog\\";
                            strFileName = strFilePath + "AlramLog_" + DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + ".txt";
                            break;
                        }
                    case (int)LogType.Network:  //Program Network Log
                        {
                            strFilePath = strExePath + "\\DATA\\LOG\\Network\\";
                            strFileName = strFilePath + "NetworkLog_" + DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + ".txt";
                            break;
                        }
                    case (int)LogType.Error: //Program Error Log
                        {
                            string CurrentTime = DateTime.Now.ToString("DATE=[yyyy-MM-dd HH:mm:ss],");
                            strMsg = CurrentTime + strMsg;

                            strFilePath = strExePath + "\\DATA\\LOG\\ErrorLog\\";
                            strFileName = strFilePath + "ErrorLog_" + DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + ".txt";
                            break;
                        }
                }

            // CFile nFile = new CFile(strFileName);
            // nFile.CreateDir(strFilePath);
            // nFile.AppendFile(strFileName, ref strMsg);
            }
            catch (System.Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }


        public static void DeleteInspectionLogData(DateTime endDt, string strDeleteRange)
        {
            try
            {
                string strExePath = Directory.GetCurrentDirectory();
                string strFilePath = strExePath + "\\Data\\Log\\InspectionLog\\";
                DirectoryInfo d = new DirectoryInfo(strFilePath);

                System.TimeSpan tspan1 = System.TimeSpan.FromTicks(endDt.Ticks);
                long endTime = 0;
                endTime = (long)tspan1.TotalSeconds;

                if (d.Exists)
                {
                    foreach (FileInfo f in d.GetFiles("*.txt"))
                    {
                        string[] strModelName = f.Name.Split(new char[] { '.' });
                        string[] strDateTime = strModelName[0].Split(new char[] { '_' });
                        string[] strDateTime1 = strDateTime[1].Split(new char[] { '-' });

                        DateTime tempDt = new DateTime(Convert.ToInt16(strDateTime1[0]), Convert.ToInt16(strDateTime1[1]), Convert.ToInt16(strDateTime1[2]));
                        System.TimeSpan tspan = System.TimeSpan.FromTicks(tempDt.Ticks);
                        long curTime = (long)tspan.TotalSeconds;

                        if (curTime <= endTime)
                        {
                            //delete file 
                            f.Delete();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        public static void DeleteProcessLogLogData(DateTime endDt, string strDeleteRange)
        {
            try
            {
                string strExePath = Directory.GetCurrentDirectory();
                string strFilePath = strExePath + "\\Data\\Log\\ProcessLog\\";
                DirectoryInfo d = new DirectoryInfo(strFilePath);

                System.TimeSpan tspan1 = System.TimeSpan.FromTicks(endDt.Ticks);
                long endTime = 0;
                endTime = (long)tspan1.TotalSeconds;


                if (d.Exists)
                {
                    foreach (FileInfo f in d.GetFiles("*.txt"))
                    {
                        string[] strModelName = f.Name.Split(new char[] { '.' });
                        string[] strDateTime = strModelName[0].Split(new char[] { '_' });
                        string[] strDateTime1 = strDateTime[1].Split(new char[] { '-' });

                        DateTime tempDt = new DateTime(Convert.ToInt16(strDateTime1[0]), Convert.ToInt16(strDateTime1[1]), Convert.ToInt16(strDateTime1[2]));
                        System.TimeSpan tspan = System.TimeSpan.FromTicks(tempDt.Ticks);
                        long curTime = (long)tspan.TotalSeconds;

                        if (curTime <= endTime)
                        {
                            //delete file 
                            f.Delete();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        public static void DeleteAlramLogData(DateTime endDt, string strDeleteRange)
        {
            try
            {
                string strExePath = Directory.GetCurrentDirectory();
                string strFilePath = strExePath + "\\Data\\Log\\AlramLog\\";
                DirectoryInfo d = new DirectoryInfo(strFilePath);

                System.TimeSpan tspan1 = System.TimeSpan.FromTicks(endDt.Ticks);
                long endTime = 0;

                endTime = (long)tspan1.TotalSeconds;


                if (d.Exists)
                {
                    foreach (FileInfo f in d.GetFiles("*.txt"))
                    {
                        string[] strModelName = f.Name.Split(new char[] { '.' });
                        string[] strDateTime = strModelName[0].Split(new char[] { '_' });
                        string[] strDateTime1 = strDateTime[1].Split(new char[] { '-' });

                        DateTime tempDt = new DateTime(Convert.ToInt16(strDateTime1[0]), Convert.ToInt16(strDateTime1[1]), Convert.ToInt16(strDateTime1[2]));
                        System.TimeSpan tspan = System.TimeSpan.FromTicks(tempDt.Ticks);
                        long curTime = (long)tspan.TotalSeconds;

                        if (curTime <= endTime)
                        {
                            //delete file 
                            f.Delete();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }

        public static void DeleteNetworkLogData(DateTime endDt, string strDeleteRange)
        {
            try
            {
                string strExePath = Directory.GetCurrentDirectory();
                string strFilePath = strExePath + "\\Data\\Log\\Network\\";
                DirectoryInfo d = new DirectoryInfo(strFilePath);

                System.TimeSpan tspan1 = System.TimeSpan.FromTicks(endDt.Ticks);
                long endTime = 0;

                endTime = (long)tspan1.TotalSeconds;

                if (d.Exists)
                {
                    foreach (FileInfo f in d.GetFiles("*.txt"))
                    {
                        string[] strModelName = f.Name.Split(new char[] { '.' });
                        string[] strDateTime = strModelName[0].Split(new char[] { '_' });
                        string[] strDateTime1 = strDateTime[1].Split(new char[] { '-' });

                        DateTime tempDt = new DateTime(Convert.ToInt16(strDateTime1[0]), Convert.ToInt16(strDateTime1[1]), Convert.ToInt16(strDateTime1[2]));
                        System.TimeSpan tspan = System.TimeSpan.FromTicks(tempDt.Ticks);
                        long curTime = (long)tspan.TotalSeconds;

                        if (curTime <= endTime)
                        {
                            f.Delete();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CLog.SaveLogFile(ex.ToString(), (int)CLog.LogType.Error);
            }
        }
    }
}

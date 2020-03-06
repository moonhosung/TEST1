using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1.Function
{

    [Serializable()]
    public struct MovePosition
    {
        internal Position position;       //위치 이름
        internal int X;            //위치 좌표 X (픽셀)
        internal int Y;            //위치 좌표 Y (픽셀)
    }

    public enum Position
    {
        STOP,
        LINE1_START,
        LINE1_END,
        LINE1_END2,
        LINE2_START,
        LINE2_END
    }

    public enum SelectMode
    {
        GROWTH,
        PEST,
        HARVEST
    }

    public struct Factory_Info
    {
        internal double Temperature; // 온도
        internal double Humidity;    // 습도
        internal double Co2;         // Co2
        internal double Sunshine;    // 일조량
    }




    public struct SetupIO_Struct
    {
        internal bool[] IOcheckIn1;
    }

    public struct ETC_Struct
    {
        internal string Str;
        internal string txtKind;
        internal int Mod;
    }

    public struct CommunicationSend_Struct
    {
        internal string txtKind;
        internal int Mod;
        internal int[] m_lAxisNo;
        internal double[] dMovePos;
        internal double[] dMoveVel;
        internal double[] dMoveAcc;
        internal double[] dMoveDec;
        internal uint Signal;
    }
    public struct Emergency_Struct
    {
        internal string txtKind;
        internal int Mod;
    }
    public struct CheckCycle_Struct
    {
        internal bool[] Signal;
        internal bool[] JudgSignal;
    }

    public struct AlarmStruct
    {
        public uint ALID;
        public int ALCD;
        public string MODULEID;
        public string ALTX;
        public ModuleTypes ModuleType;
        public int AlarmIndex;
        public bool Occurred { get; internal set; }
        public DateTime OccurredTime { get; internal set; }
    }
    

    public struct ImageStruct
    {
        internal string ImageFileName;
        internal int SizeX;
        internal int SizeY;
        internal double PCB_Thickness;
        internal int PatternWidth;
    }

    public struct SetVisionStruct
    {
        internal string Type;
        internal int No;
        internal byte[] Img;
        internal string Log;
    }
    public struct MaintVisionStruct
    {
        internal string Type;
        internal int No;
        internal byte[] Img;
        internal Bitmap LiveImg;
        internal string Log;
    }
    public struct VisionImage_Struct
    {
        internal string Type;   // 모델(Recipe), 측정
        internal int No;        // 이미지합치기,도포/미도포
        internal int count;     // 이미지 번호
        internal bool Juge;     // 이미지 합치기 여부
        internal int Fcount;   //첫줄 장수
        internal int Scount;   // 두번째 장수
        internal string msg;
    }
    public struct Display_Struct
    {
        internal string Type;
        internal int No;
        internal Bitmap Img;
        internal string msg;

    }
    public struct jobDisplay_Struct
    {
        internal string Type;
        internal int No;
        internal byte[] Img;
        internal string msg;

    }
    public struct RecipeVisionStruct
    {
        internal string Type;
        internal int No;
        internal byte[] Img;
        internal Bitmap LiveImg;
        internal string Log;
    }
    public struct Size_double
    {
        internal int X;
        internal int Y;
        internal float Offset_X;
        internal float Offset_Y;
    }

    public struct OptionStruct
    {
        internal bool Use_UV;
        internal bool Use_Vision;
        internal bool Use_Width;
        internal bool Use_Array;
        internal bool Use_Thickness;
        internal bool Use_ToolChanger;
        internal bool Use_Flow;
    }
    public struct PanelStruct
    {
        internal string Name;
        internal int ArrayCountX;
        internal int ArrayCountY;
        internal int OffsetX;
        internal int OffsetY;

        internal int GapOffsetX;
        internal int GapOffsetY;
        internal int SizeX;
        internal int SizeY;
        internal List<AreaStruct> Area;
        internal int LastWorkArea;
    }

    public struct AreaStruct
    {
        // internal DispenserStruct Dispenser;
        internal AreaMode Mode;

        internal int Z_Position;

        internal Size_double Start;
        internal Size_double End;

        internal string Work_Direction;
        internal int Speed;
        internal int Tilt;
        internal string Dispenser;
        internal string Angle;
    }

    public enum ModuleTypes : int
    {
        None = -1,
        Equipment = 0,
    }

  

    public enum AreaMode
    {
        Rectangle = 0,
        Vertical,
        Horizontal,
        Circle,
        HalfCircle
    }

    public enum AlarmLevel
    {
        None = 0,
        Warning,
        Heavy,
        Interlock
    }
    
    public enum enum_Alarm : int
    {
        Emergency_Stop = 1000,
        Left_Door_Open,
        Right_Door_Open,

        PCB_Receive_Timeout = 1100,

        Work_Conv_PCB_In_Sensor_Timeout = 1200,
        Work_Conv_PCB_Out_Sensor_Timeout,

        Out_Conv_PCB_In_Sensor_Timeout = 1300,
        Out_Conv_PCB_Out_Sensor_Timeout,
        Out_Conv_PCB_Safety_Sensor_Timeout
    }
}



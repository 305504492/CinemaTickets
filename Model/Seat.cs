using System.Drawing;

namespace Model
{
    /// <summary>
    /// ��λ��
    /// </summary>
    public class Seat
    {
        public Seat(string seatNum, Color color)
        {
            this.SeatNum = seatNum;
            this.Color = color;
        }

        /// <summary>
        /// ��λ��
        /// </summary>
        private string seatNum;
        public string SeatNum
        {
            get { return seatNum; }
            set { seatNum = value; }
        }

        /// <summary>
        /// ��ʾ�۳�������ɫ����
        /// </summary>
        private Color color;
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}

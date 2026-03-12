namespace CatchButton
{
    public partial class Form1 : Form
    {
        // 랜덤 위치 생성을 위한 Random 객체
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 마우스가 버튼 영역에 들어오면 버튼을 랜덤 위치로 이동시킨다
        /// </summary>
        private void btnCatch_MouseEnter(object sender, EventArgs e)
        {
            // 버튼이 폼 밖으로 나가지 않도록 이동 범위 제한
            int maxX = this.ClientSize.Width - btnCatch.Width;
            int maxY = this.ClientSize.Height - btnCatch.Height;

            // 랜덤한 새 좌표 계산
            int newX = random.Next(0, maxX);
            int newY = random.Next(0, maxY);

            // 버튼 위치 변경
            btnCatch.Location = new Point(newX, newY);

            // 폼 제목에 버튼의 현재 좌표 표시
            this.Text = $"숨바꼭질 버튼 - 버튼 위치: X={newX}, Y={newY}";
        }

        /// <summary>
        /// 버튼을 클릭하면 축하 메시지를 표시한다
        /// </summary>
        private void btnCatch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("축하합니다~!", "버튼 잡기", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

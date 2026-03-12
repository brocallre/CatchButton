namespace CatchButton
{
    public partial class Form1 : Form
    {
        // 랜덤 위치 생성을 위한 Random 객체
        private Random random = new Random();

        // 현재 점수
        private int score = 0;

        // 버튼의 초기 크기 저장
        private Size initialButtonSize;

        public Form1()
        {
            InitializeComponent();

            // 버튼의 초기 크기를 저장해둔다
            initialButtonSize = btnCatch.Size;

            // 초기 폼 제목 설정
            UpdateTitle();
        }

        /// <summary>
        /// 폼 제목에 점수와 버튼 좌표를 표시한다
        /// </summary>
        private void UpdateTitle()
        {
            this.Text = $"숨바꼭질 버튼 - 점수: {score}점 | 버튼 위치: X={btnCatch.Left}, Y={btnCatch.Top}";
        }

        /// <summary>
        /// 마우스가 버튼 영역에 들어오면 버튼을 랜덤 위치로 이동시키고 점수를 감점한다
        /// </summary>
        private void btnCatch_MouseEnter(object sender, EventArgs e)
        {
            // 도망갈 때 효과음 재생 (시스템 경고음)
            System.Media.SystemSounds.Exclamation.Play();

            // 도망가면 10점 감점
            score -= 10;

            // 버튼이 폼 밖으로 나가지 않도록 이동 범위 제한
            int maxX = this.ClientSize.Width - btnCatch.Width;
            int maxY = this.ClientSize.Height - btnCatch.Height;

            // 랜덤한 새 좌표 계산
            int newX = random.Next(0, maxX);
            int newY = random.Next(0, maxY);

            // 버튼 위치 변경
            btnCatch.Location = new Point(newX, newY);

            // 폼 제목 업데이트 (점수 + 좌표)
            UpdateTitle();
        }

        /// <summary>
        /// 버튼을 클릭하면 점수를 추가하고 버튼 크기를 축소한다
        /// </summary>
        private void btnCatch_Click(object sender, EventArgs e)
        {
            // 잡았을 때 효과음 재생 (성공음)
            System.Media.SystemSounds.Asterisk.Play();

            // 클릭하면 100점 추가
            score += 100;

            // 클릭 성공할 때마다 버튼 크기를 10%씩 축소 (난이도 상승)
            int newWidth = (int)(btnCatch.Width * 0.9);
            int newHeight = (int)(btnCatch.Height * 0.9);

            // 최소 크기 제한 (너무 작아지면 클릭이 불가능하므로)
            if (newWidth >= 20 && newHeight >= 10)
            {
                btnCatch.Size = new Size(newWidth, newHeight);
            }

            // 폼 제목 업데이트
            UpdateTitle();

            // 축하 메시지 박스 표시
            MessageBox.Show("축하합니다~!", "버튼 잡기", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

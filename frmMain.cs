namespace DiceRoller
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRollDamage_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();

            int dieCount = int.Parse(cmbDieCount.Text);
            int dieSize = int.Parse(cmbDieSize.Text);
            int bonus = int.Parse(cmbRollBonus.Text);

            List<int> results = new List<int>();

            for (int dieNo = 0; dieNo < dieCount; dieNo++)
            {
                results.Add(rnd.Next(1, dieSize + 1));
            }

            lblDamageResult.Text = (results.Sum() + bonus).ToString();

        }

        private void btnRollCheck_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int ability = int.Parse(cmbAbilityScore.Text);
            int bonus = int.Parse(cmbCheckBonus.Text);

            int modifier = Convert.ToInt32(Math.Floor((ability - 10) / 2.00));

            if (rbNone.Checked)
            {
                int result = rnd.Next(1, 21);

                if (result == 20)
                {
                    lblCheckResult.Text = "NAT 20";
                }
                else if (result == 1)
                {
                    lblCheckResult.Text = "NAT 1";
                }
                else
                {
                    getResult(result, modifier, bonus);
                }
            }
            else if (rbAdv.Checked || rbDisadv.Checked)
            {
                int advResult = 0;
                int result1 = rnd.Next(1, 21);
                int result2 = rnd.Next(1, 21);

                if (rbAdv.Checked)
                {
                    advResult = Math.Max(result1, result2);
                }
                else if (rbDisadv.Checked)
                {
                    advResult = Math.Min(result1, result2);
                }

                if (advResult == 20)
                {
                    lblCheckResult.Text = "NAT 20";
                    lblWorkings.Text = "Rolled " + result1 + " and " + result2;
                }
                else if (advResult == 1)
                {
                    lblCheckResult.Text = "NAT 1";
                    lblWorkings.Text = "Rolled " + result1 + " and " + result2;
                }
                else
                {
                    getResult(advResult, modifier, bonus);
                }


            }

        }

        private void getResult(int result, int modifier, int bonus)
        {
            int rollResult = result + modifier + bonus;
            lblCheckResult.Text = rollResult.ToString();
            lblWorkings.Text = "Rolled " + result + " \n " + modifier + " Ability Modifier " + "\n" + bonus + " Bonus ";
        }


        private void rbAdv_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdv.Checked)
            {
                rbDisadv.Checked = false;
                rbNone.Checked = false;
            }
        }

        private void rbDisadv_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDisadv.Checked)
            {
                rbAdv.Checked = false;
                rbNone.Checked = false;
            }
        }

        private void rbNone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNone.Checked)
            {
                rbDisadv.Checked = false;
                rbAdv.Checked = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rbNone.Checked = true;
        }
    }
}
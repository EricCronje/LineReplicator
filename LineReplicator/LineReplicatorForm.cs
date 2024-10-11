namespace LineReplicator
{
    public partial class LineReplicatorForm : Form
    {
        private const string CPlaceHolder = "$1";

        public LineReplicatorForm()
        {
            InitializeComponent();
        }

        private void PerformReplaceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ClearOutputAndResult();

                if (!templateRtb.Text.Contains(CPlaceHolder))
                    templateRtb.Text = LineReplicatorHelper.LineReplictorHelper.AddPlaceHolderInTemplateIfInList(inputRtb.Lines, templateRtb.Text);

                outputRtb.Text = LineReplicatorHelper.LineReplictorHelper.ReplacePaceHolderInList(inputRtb.Lines, templateRtb.Text);
                Clipboard.SetText(outputRtb.Text);

                outputRtb.Enabled = false;
                resultRtb.Text = LineReplicatorHelper.LineReplictorHelper.FeedbackMessage;
            }
            catch (Exception err)
            {
                resultRtb.Text = err.Message;
            }

        }

        private void ClearOutputAndResult()
        {
            outputRtb.Clear();
            resultRtb.Clear();
        }

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            inputRtb.Clear();
            templateRtb.Clear();
            ClearOutputAndResult();
        }

    }
}

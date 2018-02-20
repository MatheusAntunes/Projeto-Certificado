namespace System.ComponentModel
{
    internal class ConsoleCancelEventArgs
    {
        private Action<object, CancelEventArgs> txtSenha_LostFocus;

        public ConsoleCancelEventArgs(Action<object, CancelEventArgs> txtSenha_LostFocus)
        {
            this.txtSenha_LostFocus = txtSenha_LostFocus;
        }
    }
}
namespace Notes
{
    public partial class MainPage : ContentPage
    {

        string filepath = Path.Combine(FileSystem.AppDataDirectory, "Notes.txt");
        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(filepath))
            {
                EditorSalvar.Text = File.ReadAllText(filepath);
            }

        }

        public void SaveButton_Clicked(object sender, EventArgs e)
        {
            String texto = EditorSalvar.Text;

            File.WriteAllText(filepath,texto);//
            DisplayAlert("Salvo", "Seu Arquivo foi salvo", "ok");
            


        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            

            if (File.Exists(filepath))
            {
                File.Delete(filepath); //Deleta arquivo
                DisplayAlert("Operação concluida", "Arquivo deletado com Sucesso", "Ok");
                EditorSalvar.Text = null;
            }
            else
            {
                DisplayAlert("Alerta", "O Arquivo já foi deletado", "Ok");
            }
        }
    }

}

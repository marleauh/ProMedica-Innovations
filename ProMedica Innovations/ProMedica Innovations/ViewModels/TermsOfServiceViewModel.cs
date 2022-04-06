namespace ProMedica_Innovations.ViewModels
{
    public class TermsOfServiceViewModel
    {

        public bool IsPdf { get; set; }
        public string Uri { get; set; }

        public TermsOfServiceViewModel(string uri, bool isPdf)
        {
            Uri = uri;
            IsPdf = isPdf;
        }

    }
}

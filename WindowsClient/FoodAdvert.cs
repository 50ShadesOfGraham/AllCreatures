using BusinessEntities;
using BusinessLayer;

namespace WindowsClient
{
    public partial class FoodAdvert : Form
    {
        private Food Advertisement;
        private IModel Model;
        public FoodAdvert(IModel _model, Food advert)
        {
            InitializeComponent();
            this.Model = _model;
            this.Advertisement = advert;

        }
        

        private void FoodAdvert_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Advertisement.Title;
            txtPrice.Text = Advertisement.Price.ToString();
            txtDescription.Text = Advertisement.Description;
            //txtDetails.Text = Advertisement.FoodDetails;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            PaymentDetails paymentDetails = new PaymentDetails(Model);
            Hide();
            paymentDetails.Show();
        }
    }
}

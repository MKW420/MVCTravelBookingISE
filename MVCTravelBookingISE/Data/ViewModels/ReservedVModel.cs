namespace MVCTravelBookingISE.Data.ViewModels
{
    public class ReservedVModel
    {

        public ReservedVModel()
        {
            ValuesList = new Dictionary<int, int>();
        }

        public Dictionary<int,int> ValuesList { get; set; }


        public ReservedVModel Add(int key, int value)
        {
            ValuesList.Add(key, value);
            return this;
        }
    }
}

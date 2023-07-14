namespace Bakery.Models {
    interface IFoodItem {
        private int Amount {get{return Amount;}set{}}
        public int getCost();
    }
}
namespace Bakery.Models {
    class Pastry : IFoodItem {
        private int _quantity;
        private int _price = 2;
        public int Quantity {
            get => _quantity;
            set => _quantity = value;
        }
        public int Price {
            get => _price;
        }
        public Pastry() {
            Quantity = 0;
        }
        public Pastry(int quantity) {
            Quantity = quantity;
        }
        public int getCost() {
            return -1;
        }
    }
}
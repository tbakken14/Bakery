namespace Bakery.Models {
    public class Bread : IFoodItem {
        private int _quantity;
        private int _price = 2;
        public int Quantity {
            get => _quantity;
            set => _quantity = value;
        }

        public int Price {
            get => _price;
        }
        public Bread() {
            Quantity = 0;
        }
        public Bread(int quantity) {
            Quantity = quantity;
        }
        public int getCost() {
            return -1;
        }
    }
}
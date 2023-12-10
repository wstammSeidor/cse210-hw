using System.Reflection.Metadata.Ecma335;

public class Order{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(Customer customer){
        _customer = customer;
    }

    public double calculateTotalCost(){
        double totalCost = 0;
        foreach(Product product in _products){
            totalCost += product.calculateProductPrice();
        }

        if(_customer.isUSACustomer()){
            totalCost += totalCost + 5;
        }
        else{
            totalCost += totalCost + 35;
        }
        return totalCost;
    }

    public string getPackingLabel(){
        string packingLabel = "";
        foreach(Product product in _products){
            packingLabel += product.GetPackingLabel();
        }
        return packingLabel;
    }

    public string getShippingLabel(){
        string shippingLabel = "";
        shippingLabel += _customer.GetShippingLabel();
        shippingLabel += getPackingLabel();
        return shippingLabel;
    }

    public void AddProduct(Product product){
        _products.Add(product);
    }

    public string getCostShipping(){
        if(_customer.isUSACustomer()){
            return "5";
        }
        else{
            return "35";
        }
    }

}
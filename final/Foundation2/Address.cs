public class Address{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;


    public Address(string streetAddress, string city, string stateProvince, string country){
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool isInUSA(){
        return _country == "USA";
    }

    public string getAddress(){
        return  "Street: " + _streetAddress + " City: " + _city + ", " + _stateProvince + " " + _country;
    }
}
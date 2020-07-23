class Organization {
    string id;
    string eName; //English name
    string cName; //Chinese name
    string telCountryCode; // Country.code
    string telAreaCode; // CountryArea.code
    string telLocalNumber;
    string faxCountryCode; // Country.code
    string faxAreaCode; // CountryArea.code
    string faxLocalNumber;
    string contactPersonId; // contactPerson.Id
}

class Country{
    string code; // Primary key
    string eName; //English country name
    string cName; //Chinese country name
}

class CountryArea{
    string countryCode; // countryCode and Code are composite primary key 
    string code;
    string eName; //English area name
    string cName; //Chinese area name
}

class contactPerson{
    string Id;
    string eFirstName; //First name and last name in English
    string eLastName;
    string cFirstName; //First name and last name in Chinese
    string cLastName;
    string telCountryCode; // Country.code
    string telAreaCode; // CountryArea.code
    string telNumber;
    string faxCountryCode; // Country.code
    string faxAreaCode; // CountryArea.code
    string faxLocalNumber;
    string mobileCountryCode; // Country.code
    string mobileAreaCode; // CountryArea.code
    string mobileLocalNumber;
}
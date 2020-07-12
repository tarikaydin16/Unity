using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    public Customer customer1;
    public Customer customer2;
    public Customer customer3;
    // Start is called before the first frame update
    void Start()
    {
        customer1 = new Customer("Tarık", "Aydın", 20, "M", "Electricial engineering");
        customer2 = new Customer("Tarık", "Aydın", 20, "F", "Software Engineering");
        customer3 = new Customer("Tarık", "Aydın", 20, "M", "Influncer");
    }


}

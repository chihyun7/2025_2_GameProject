using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkRequest : MonoBehaviour
{
   public ProductType ProductType;
    public int quantity;
    public int reward;

    public WorkRequest(ProductType productType, int quantity, int reward)
    {
        this.ProductType = productType;
        this.quantity = quantity;
        this.reward = reward;
    }
}

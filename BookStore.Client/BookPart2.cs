namespace BookStore.Client
{
    using System;
    using System.Collections.Generic;

    public partial class book
    {
       
        public string report()
        {
            return $"#{this.Id} Name:{this.Name} Price:{this.Price}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Warehouse
    {
        int T = int.Parse(Console.ReadLine());

        public void Toys()
        {
            for(int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                List<Shipment> shipments = new List<Shipment>();

                for(int j = 0; j < n; j++)
                {
                    Shipment shipment = new Shipment();
                    string[] toys = Console.ReadLine().Split();
                    Shipment toyExists = shipments.Where(n => n.Name == toys[0]).FirstOrDefault();

                    if(toyExists == null)
                    {
                        shipment.Name = toys[0];
                        shipment.Num = int.Parse(toys[1]);
                    }
                    else
                    {
                        toyExists.Num += int.Parse(toys[1]);
                    }
                    shipments.Add(shipment);
                }

                List<Shipment> shipmentsSorted = shipments.OrderByDescending(n => n.Num).ThenBy(n => n.Name).ToList();
                shipmentsSorted.RemoveAll(n => n.Name == null);

                Console.WriteLine(shipmentsSorted.Count());

                foreach(var shipment in shipmentsSorted)
                {
                    if(shipment.Name != null && shipment.Num != 0)
                        Console.WriteLine(shipment.Name + " " + shipment.Num);
                }
            }
        }
    }

    //public class Shipment
    //{
    //    public string Name { get; set; }
    //    public int Num { get; set; }

    //}
}

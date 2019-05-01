namespace GoatStore.Models {
  public class Order {
    public Order(int a, string i, string l) {
        this.Amount = a;
        this.Id = i;
        this.Location = l;
    }

    public int Amount { get; set; }
    public string Id { get; set; }
    public string Location { get; set; }
}
}
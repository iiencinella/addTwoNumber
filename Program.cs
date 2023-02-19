class ListNode {
  public int val;
  public ListNode next;
  public ListNode(int val=0, ListNode next=null) {
    this.val = val;
    this.next = next;
  }
}

internal class Program {
  private static void Main(string[] args) {
  ListNode number1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
  ListNode number2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

  ListNode addResult = AddTwoNumbers(number1, number2);

  Console.WriteLine("Number 1: " + ShowList(number1));
  Console.WriteLine("Number 2: " + ShowList(number2));
  Console.WriteLine("Sum Result: " + ShowList(addResult));
  }

  private static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
    ListNode result = new ListNode(0);
    ListNode curr = result;

    int carry = 0;
    int numberResult = 0;
    
    int number1 = 0;
    int number2 = 0;
    while(l1 != null || l2 != null || carry != 0) {
      number1 = l1 != null ? l1.val : 0;
      number2 = l2 != null ? l2.val : 0;
      numberResult = number1 + number2 + carry;
      carry = numberResult / 10;

      curr.next = new ListNode(numberResult % 10);
      curr = curr.next;

      if(l1 != null)
        l1 = l1.next;
      if(l2 != null)
        l2 = l2.next;
    }

    return result.next;
  }

  private static string ShowList(ListNode list) {
    string result = "";

    while(list != null) {
      result = list.val.ToString() + result;
      list = list.next;
    }

    return result;
  }
}
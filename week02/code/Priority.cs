/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a priority queue with the following people and priorities: Bob (2), Tim (5), Sue (3), 
        //           dequeue them in the correct order depending on their priority, and return their value
        // Expected Result: Tim, Sue, Bob
        Console.WriteLine("Test 1");
        var customers = new PriorityQueue();
        customers.Enqueue("Bob", 2);
        customers.Enqueue("Tim", 5);
        customers.Enqueue("Sue", 3);
        Console.WriteLine(customers.ToString());

        for (int i = 0; i < 3; i++) {
            Console.WriteLine(customers.Dequeue());
        }

        // Defect(s) Found: The highest priority item is displayed every time, which means it isn't actually dequeued.
        // It remains in the queue.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a priority queue with the following people and priorities: Bob (2), Sue (3), John (5), George (3), Tim (5),
        //           and dequeue them in the correct order. If there are two or more items with the highest priority,
        //           remove the item closest to the front of the queue and return its value.
        // Expected Result: John, Tim, Sue, George, Bob
        Console.WriteLine("Test 2");

        customers = new PriorityQueue();
        customers.Enqueue("Bob", 2);
        customers.Enqueue("Sue", 3);
        customers.Enqueue("John", 5);
        customers.Enqueue("George", 3);
        customers.Enqueue("Tim", 5);
        Console.WriteLine(customers.ToString());

        for (int i = 0; i < 5; i++) {
            Console.WriteLine(customers.Dequeue());
        }

        // Defect(s) Found: The highest priority item is displayed every time, which means it isn't actually dequeued.
        // It remains in the queue.

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Try to deque someone from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 3");
        customers = new PriorityQueue();
        Console.WriteLine(customers.Dequeue());

        // Defect(s) Found: No defects found. Error message is displayed.

        Console.WriteLine("---------");
    }
}
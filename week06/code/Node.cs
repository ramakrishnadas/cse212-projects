public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data) {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // if value is equal to Data, then just return without inserting anything
        else {
            return;
        }
        
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        
        // if the value is the current node, then return true
        if (value == Data) {
            return true;
        }
        // if value is less than Data, we search in the left subtree (as long as it is not null)
        else if (value < Data) {
            if (Left != null)
                return Left.Contains(value);
        } 
        // if value is greater than Data, we search in the right subtree (as long as it is not null)
        else {
            if (Right != null)
                return Right.Contains(value);
        }

        return false;
        
    }

    public int GetHeight() {
        // TODO Start Problem 4
        // Base case: if the node is null, then its height is 0
        if (this == null)
        {
            return 0;
        }

        // Use ternary expression to assign value to the variables that represent the height of the Left and Right subtrees
        // if the Right or Left subtree is null, then its height is 0; otherwise, make a recursive call to the subtree
        int rightHeight = (Right == null) ? 0 : Right.GetHeight();
        int leftHeight = (Left == null) ? 0 : Left.GetHeight();

        // return 1 (which is the root element) plus the height of the tallest subtree (Left or Right)
        return 1 + Math.Max(rightHeight, leftHeight);
        
    }
}
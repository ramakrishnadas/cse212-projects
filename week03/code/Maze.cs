/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze {
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap) {
        _mazeMap = mazeMap;
    }

    // Todo Maze Problem - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveLeft() {
        // FILL IN CODE

        // Store the list of booleans (which informs us of the valid directions) into a variable
        // Check if the first item in the list of booleans (validDirections[0]), which corresponds to "Left",  is false
        // If it's false, display "Can't go that way!". Otherwise, move left on the X axis.
        bool[] validDirections = _mazeMap[(_currX, _currY)];
        if (!validDirections[0]) 
            Console.WriteLine("Can't go that way!");
        else
            _currX -= 1;
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveRight() {
        // FILL IN CODE

        // Store the list of booleans (which informs us of the valid directions) into a variable
        // Check if the second item in the list of booleans (validDirections[1]), which corresponds to "Right",  is false
        // If it's false, display "Can't go that way!". Otherwise, move right on the X axis.
        bool[] validDirections = _mazeMap[(_currX, _currY)];
        if (!validDirections[1]) 
            Console.WriteLine("Can't go that way!");
        else
            _currX += 1;
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveUp() {
        // FILL IN CODE

        // Store the list of booleans (which informs us of the valid directions) into a variable
        // Check if the third item in the list of booleans (validDirections[2]), which corresponds to "Up",  is false
        // If it's false, display "Can't go that way!". Otherwise, move up on the Y axis.
        bool[] validDirections = _mazeMap[(_currX, _currY)];
        if (!validDirections[2]) 
            Console.WriteLine("Can't go that way!");
        else
            _currY -= 1;
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveDown() {
        // FILL IN CODE

        // Store the list of booleans (which informs us of the valid directions) into a variable
        // Check if the fourth item in the list of booleans (validDirections[3]), which corresponds to "Down",  is false
        // If it's false, display "Can't go that way!". Otherwise, move down on the Y axis.
        bool[] validDirections = _mazeMap[(_currX, _currY)];
        if (!validDirections[3]) 
            Console.WriteLine("Can't go that way!");
        else
            _currY += 1;
    }

    public void ShowStatus() {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}
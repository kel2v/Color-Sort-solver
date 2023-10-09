# Color-Sort-solver
A windows application, built using VB.net, that can provide solution (steps) to solve any Color-Sort puzzle of easy and moderate complexicity (upto 10 tubes with upto 7 spaces/layers per tube)

# How to Run the Executable:
**Warning: (This instruction maybe wrong or insufficient, please wait for the update about installation)**
1. Install .NET Desktop SDK
2. Download the files inside the `bin/release/net6.0-windows/` file
3. Open the Application by double-clicking the `ColorSort.exe` file on your computer

# How to use
**Enter the parametere:**  
1. Tube count: The total number of tubes your puzzle have.
2. Tube Capacity: Number of units of Layers each Tube can store at max. Most of the color-sort puzzles have 4 layers at max a tube can store.
3. Color Count: Number of different colors your puzzle has.

After entering these parameters, click **Submit** to continue. Click **Reset** to start again

**Indicate the Tubes' state:**  
Represent the current state of all the Tubes of your puzzle by using the Color palet given below. Initialize every layer of each tube by picking a color from the color pallete and clicking the layer to color it with the 'picked' color. Click again to uncolor it.
After initializing the Tubes' state, click **Submit** to get the result. Click **Reset** to uncolor all the layers of all the Tubes.

**Get the steps to solve the puzzle:**  
On success, you get a list of steps that you need to follow to solve the puzzle.
For example, you may get result as:
```
1). 1 -> 5      Pour the entire layer (may include more than one unit of Tube's layer) of the liquid of a particular color of Tube 1 to Tube 5
2). 3 -> 2      Pour the entire layer (may include more than one unit of Tube's layer) of the liquid of a particular color of Tube 3 to Tube 2
3). 6 -> 4      Pour the entire layer (may include more than one unit of Tube's layer) of the liquid of a particular color of Tube 6 to Tube 4
.
.
.
```

# Report any error here
Please report any errors you face here in this repositoy. 

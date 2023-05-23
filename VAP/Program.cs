
BerthAllocationProblem problem = new BerthAllocationProblem();

// Adding ships
problem.AddShip("Ship1", 2, 5);
problem.AddShip("Ship2", 3, 6);
problem.AddShip("Ship3", 4, 7);

// Adding berths
problem.AddBerth("Berth1", 1);
problem.AddBerth("Berth2", 2);

// Allocating berths
problem.AllocateBerths();
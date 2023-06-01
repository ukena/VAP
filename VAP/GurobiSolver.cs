using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAP;
// TODO: TEST

public class SimpleBerthAllocationProblemSolver
{
    public void Solve(BerthAllocationInstance instance)
    {
        int numberOfShips = instance.Ships.Length;
        int berthLength = instance.Berth.Length;

        try
        {
            GRBEnv env = new GRBEnv();
            GRBModel model = new GRBModel(env);

            // Decision variables
            GRBVar[] s = new GRBVar[numberOfShips];
            GRBVar[] b = new GRBVar[numberOfShips];
            GRBVar[,] x = new GRBVar[numberOfShips, numberOfShips];
            GRBVar[,] y = new GRBVar[numberOfShips, numberOfShips];

            // Variable bounds
            for (int i = 0; i < numberOfShips; i++)
            {
                s[i] = model.AddVar(0, GRB.INFINITY, 0, GRB.CONTINUOUS, $"s[{i}]");
                b[i] = model.AddVar(0, berthLength, 0, GRB.CONTINUOUS, $"b[{i}]");

                for (int j = 0; j < numberOfShips; j++)
                {
                    x[i, j] = model.AddVar(0, 1, 0, GRB.BINARY, $"x[{i},{j}]");
                    y[i, j] = model.AddVar(0, 1, 0, GRB.BINARY, $"y[{i},{j}]");
                }
            }

            // Objective function
            GRBLinExpr objExpr = new GRBLinExpr();
            for (int i = 0; i < numberOfShips; i++)
            {
                for (int j = 0; j < numberOfShips; j++)
                {
                    objExpr.AddTerm(1.0, x[i, j]);
                    objExpr.AddTerm(1.0, y[i, j]);
                }
            }
            model.SetObjective(objExpr, GRB.MINIMIZE);

            // Constraints
            // TODO: Add constraints

            // Optimize the model
            model.Optimize();

            // Get the solution
            if (model.Get(GRB.IntAttr.Status) == GRB.Status.OPTIMAL)
            {
                double objectiveValue = model.Get(GRB.DoubleAttr.ObjVal);
                Console.WriteLine("Optimal solution found!");
                Console.WriteLine("Objective value: " + objectiveValue);

                // TODO: Retrieve and process the variable values
            }
            else
            {
                Console.WriteLine("No feasible solution found.");
            }

            // Dispose of the model and environment
            model.Dispose();
            env.Dispose();
        }
        catch (GRBException ex)
        {
            Console.WriteLine("Error code: " + ex.ErrorCode + ". " + ex.Message);
        }
    }
}
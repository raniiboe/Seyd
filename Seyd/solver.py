import highspy
import numpy as np

def solve():
	h = highspy.Highs()
	inf = highspy.kHighsInf
	# Define two variables, first using identifiers for the bound values,
	# and then using constants
	lower = 0
	upper = 4
	h.addVar(lower, upper)
	h.addVar(1, inf)

	# Define the objective coefficients (costs) of the two variables,
	# identifying the variable by index, and changing its cost from the
	# default value of zero
	cost = 1
	h.changeColCost(0, cost)
	h.changeColCost(1, 1)

	# Define constraints for the model
	#
	# The first constraint (x1<=7) has only one nonzero coefficient,
	# identified by variable index 1 and value 1
	num_nz = 1
	index = 1
	value = 1
	h.addRow(-inf, 7, num_nz, index, value)

	# The second constraint (5 <= x0 + 2x1 <= 15) has two nonzero
	# coefficients, so arrays of indices and values are required
	num_nz = 2
	index = np.array([0, 1])
	value = np.array([1, 2])
	h.addRow(5, 15, num_nz, index, value)

	# The final constraint (6 <= 3x0 + 2x1) has the same indices but
	# different values
	num_nz = 2
	value = np.array([3, 2])
	h.addRow(6, inf, num_nz, index, value)

	# Access LP
	lp = h.getLp()
	num_nz = h.getNumNz()
	print('LP has ', lp.num_col_, ' columns', lp.num_row_, ' rows and ', num_nz, ' nonzeros')
	return "heuy"
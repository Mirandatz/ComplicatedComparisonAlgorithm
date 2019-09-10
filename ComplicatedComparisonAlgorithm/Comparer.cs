namespace ComplicatedComparisonAlgorithm {
	using System;
	using System.Collections.Generic;
	using System.Text;

	public sealed class FloatArrayComparer: IComparer<FloatArray> {

		public int Compare(FloatArray lhs, FloatArray rhs) {
			for (int i = 0; i < lhs.Count; i++) {
				if (lhs[i] < rhs[i])
					return -1;
				else if (lhs[i] > rhs[i])
					return 1;
			}

			return 0;
		}
	}
}

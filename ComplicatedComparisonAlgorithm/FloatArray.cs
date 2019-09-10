namespace ComplicatedComparisonAlgorithm {
	using System;
	using System.Linq;

	public sealed class FloatArray {
		private readonly float[] _values;

		public readonly int Count;

		public FloatArray(float[] values) {
			if (values is null)
				throw new ArgumentNullException(nameof(values));
			if (values.Any(v => float.IsNaN(v)))
				throw new ArgumentException(values + " can't contain NaNs.");

			_values = values.ToArray();
			Count = _values.Length;
		}

		public float this[int index] => _values[index];
	}
}

namespace ComplicatedComparisonAlgorithm {
	using System;

	public class Program {

		public static void Main(string[] args) {

			var unsorted = new FloatArray[] {
				new FloatArray(new float[] {0.4032445f, 144}),
				new FloatArray(new float[] {0.3778533f, 144}),
				new FloatArray(new float[] {0.1739699f, 144}),
				new FloatArray(new float[] {0.3778533f, 144}),
				new FloatArray(new float[] {0.4032445f, 144}),
				new FloatArray(new float[] {0.1962067f, 144}),
				new FloatArray(new float[] {0.2236756f, 144}),
				new FloatArray(new float[] {0.376882f, 144}),
				new FloatArray(new float[] {0.275862f, 144}),
				new FloatArray(new float[] {0.3972802f, 144}),
				new FloatArray(new float[] {0.2236756f, 144}),
				new FloatArray(new float[] {0.1962067f, 144}),
				new FloatArray(new float[] {0.376882f, 144}),
				new FloatArray(new float[] {0.2236756f, 144}),
				new FloatArray(new float[] {0.4032445f, 144}),
				new FloatArray(new float[] {0.3684821f, 144}),
				new FloatArray(new float[] {0.3603691f, 144}),
				new FloatArray(new float[] {0.4032445f, 144}),
				new FloatArray(new float[] {0.3113146f, 144}),
				new FloatArray(new float[] {0.3176299f, 144}),
				new FloatArray(new float[] {0.2236756f, 144}),
				new FloatArray(new float[] {0.3972802f, 144}),
				new FloatArray(new float[] {0.4325995f, 144}),
				new FloatArray(new float[] {0.275862f, 144}),
				new FloatArray(new float[] {0.2972316f, 144}),
				new FloatArray(new float[] {0.376882f, 144}),
				new FloatArray(new float[] {0.3603691f, 144}),
				new FloatArray(new float[] {0.275862f, 144}),
				new FloatArray(new float[] {0.2236756f, 144}),
				new FloatArray(new float[] {0.2040549f, 144}),
				new FloatArray(new float[] {0.4032445f, 144}),
				new FloatArray(new float[] {0.3113146f, 144}),
				new FloatArray(new float[] {0.2040549f, 144}),
				new FloatArray(new float[] {0.2236756f, 144}),
				new FloatArray(new float[] {0.275862f, 144}),
				new FloatArray(new float[] {0.4032445f, 144}),
				new FloatArray(new float[] {0.3113146f, 144}),
				new FloatArray(new float[] {0.3113146f, 144}),
				new FloatArray(new float[] {0.3176299f, 144}),
				new FloatArray(new float[] {0.3118019f, 144}),
				new FloatArray(new float[] {0.3778533f, 144}),
				new FloatArray(new float[] {0.4032445f, 144}),
				new FloatArray(new float[] {0.3127732f, 144}),
				new FloatArray(new float[] {0.3176299f, 144}),
				new FloatArray(new float[] {0.3603691f, 144}),
				new FloatArray(new float[] {0.275862f, 144}),
				new FloatArray(new float[] {0.2236756f, 144}),
				new FloatArray(new float[] {0.376882f, 144}),
				new FloatArray(new float[] {0.3176299f, 144}),
				new FloatArray(new float[] {0.3603691f, 144})};

			Array.Sort(
				keys: unsorted,
				items: unsorted,
				comparer: new FloatArrayComparer());

			Console.WriteLine("Hello World!");
		}
	}
}

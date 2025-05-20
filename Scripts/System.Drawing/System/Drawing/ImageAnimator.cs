using System.Collections;

namespace System.Drawing;

/// <summary>Animates an image that has time-based frames.</summary>
public sealed class ImageAnimator
{
	private static Hashtable ht;

	/// <summary>Displays a multiple-frame image as an animation.</summary>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> object to animate.</param>
	/// <param name="onFrameChangedHandler">An <see langword="EventHandler" /> object that specifies the method that is called when the animation frame changes.</param>
	public static void Animate(Image image, EventHandler onFrameChangedHandler)
	{
	}

	/// <summary>Returns a Boolean value indicating whether the specified image contains time-based frames.</summary>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> object to test.</param>
	/// <returns>This method returns <see langword="true" /> if the specified image contains time-based frames; otherwise, <see langword="false" />.</returns>
	public static bool CanAnimate(Image image)
	{
		return false;
	}

	/// <summary>Terminates a running animation.</summary>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> object to stop animating.</param>
	/// <param name="onFrameChangedHandler">An <see langword="EventHandler" /> object that specifies the method that is called when the animation frame changes.</param>
	public static void StopAnimate(Image image, EventHandler onFrameChangedHandler)
	{
	}

	/// <summary>Advances the frame in the specified image. The new frame is drawn the next time the image is rendered. This method applies only to images with time-based frames.</summary>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> object for which to update frames.</param>
	public static void UpdateFrames(Image image)
	{
	}

	private static void UpdateImageFrame(Image image)
	{
	}
}

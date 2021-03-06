
// Copyright (C) 2012-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;

namespace OpenGL
{
	/// <summary>
	/// Pixel color space.
	/// </summary>
	public enum PixelSpace
	{
		/// <summary>
		/// Grayscale.
		/// </summary>
		Red,
		/// <summary>
		/// Gray scale and Alpha.
		/// </summary>
		GrayAlpha,
		/// <summary>
		/// RGB.
		/// </summary>
		Rgb,
		/// <summary>
		/// sRGB.
		/// </summary>
		sRgb,
		/// <summary>
		/// sBGR.
		/// </summary>
		sBgr,
		/// <summary>
		/// RGB and Alpha
		/// </summary>
		Rgba,
		/// <summary>
		/// Linear BGR.
		/// </summary>
		Bgr,
		/// <summary>
		/// BGR and Alpha.
		/// </summary>
		Bgra,
		/// <summary>
		/// Luminance/chrominance.
		/// </summary>
		YUV,
		/// <summary>
		/// Cyan, Magenta and Yellow.
		/// </summary>
		CMY,
		/// <summary>
		/// Cyan, Magenta, Yellow and Black.
		/// </summary>
		CMYK,
		/// <summary>
		/// Cyan, Magenta, Yellow, Black and Alpha.
		/// </summary>
		CMYKA,
		/// <summary>
		/// Depth.
		/// </summary>
		Depth,
		/// <summary>
		/// Combined depth/stencil.
		/// </summary>
		DepthStencil,
		/// <summary>
		/// Integral integer texture.
		/// </summary>
		Integer,
	}
}


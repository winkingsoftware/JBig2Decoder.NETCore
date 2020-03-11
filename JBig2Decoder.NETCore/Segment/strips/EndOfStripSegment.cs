using System;
using System.Collections.Generic;
using System.Text;

namespace JBig2Decoder.NETCore
{
	public class EndOfStripeSegment : Segment
	{

		public EndOfStripeSegment(JBIG2StreamDecoder streamDecoder) : base(streamDecoder) { }

		public override void readSegment()
		{
			for (int i = 0; i < this.getSegmentHeader().getSegmentDataLength(); i++)
			{
				decoder.readbyte();
			}
		}
	}
}

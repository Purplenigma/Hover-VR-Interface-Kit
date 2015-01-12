﻿using Henu.State;

namespace Henu.Display {

	/*================================================================================================*/
	public interface IUiMenuPointRenderer {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		void Build(ArcState pHand, ArcSegmentState pPoint);
		
		/*--------------------------------------------------------------------------------------------*/
		void Update();

		/*--------------------------------------------------------------------------------------------*/
		void HandleChangeAnimation(bool pFadeIn, int pDirection, float pProgress);

	}

}
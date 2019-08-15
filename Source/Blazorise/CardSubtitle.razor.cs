﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise
{
    public abstract class BaseCardSubtitle : BaseComponent
    {
        #region Members

        private int size = 6;

        #endregion

        #region Methods

        protected override void RegisterClasses()
        {
            ClassMapper
                .Add( () => ClassProvider.CardSubtitle() )
                .Add( () => ClassProvider.CardSubtitleSize( Size ) );

            base.RegisterClasses();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Number from 1 to 6 that defines the subtitle size where the smaller number means larger text.
        /// </summary>
        /// <remarks>
        /// todo: change to enum
        /// </remarks>
        [Parameter]
        public int Size
        {
            get => size;
            set
            {
                size = value;

                ClassMapper.Dirty();
            }
        }

        [Parameter] public RenderFragment ChildContent { get; set; }

        #endregion
    }
}

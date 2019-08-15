﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise
{
    public abstract class BaseDropdownItem : BaseComponent
    {
        #region Members

        private bool isActive;

        #endregion

        #region Methods

        protected override void RegisterClasses()
        {
            ClassMapper
                .Add( () => ClassProvider.DropdownItem() )
                .If( () => ClassProvider.DropdownItemActive(), () => IsActive );

            base.RegisterClasses();
        }

        protected void ClickHandler()
        {
            Clicked.InvokeAsync( Value );
        }

        #endregion

        #region Properties

        /// <summary>
        /// Holds the item value.
        /// </summary>
        [Parameter] public object Value { get; set; }

        /// <summary>
        /// Indicate the currently active item.
        /// </summary>
        [Parameter]
        public bool IsActive
        {
            get => isActive;
            set
            {
                isActive = value;

                ClassMapper.Dirty();
            }
        }

        /// <summary>
        /// Occurs when the item is clicked.
        /// </summary>
        [Parameter] public EventCallback<object> Clicked { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        #endregion
    }
}

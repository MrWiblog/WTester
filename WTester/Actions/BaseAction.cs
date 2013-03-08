﻿namespace stillbreathing.co.uk.WTester.Actions
{
    /// <summary>
    /// The base Action from which all internal WTester Action derive
    /// </summary>
	public abstract class BaseAction : IAction
	{
        /// <summary>
        /// Gets or sets the WTest that this Action belongs to
        /// </summary>
        public WTest Test { get; set; }

        /// <summary>
        /// Gets or sets the message shown just before the action is invoked
        /// </summary>
        public string PreActionMessage { get; set; }

        /// <summary>
        /// Gets or sets the message shown just after the action is invoked
        /// </summary>
        public string PostActionMessage { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating the succes or failure of the Action
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// The method that is called just before the action is executed
        /// </summary>
        public abstract void PreAction();

        /// <summary>
        /// The method that is invoked when the Action is run
        /// </summary>
        public abstract void Execute();
	}
}

namespace Breakout.Logic.State
{
    /// <summary>
    /// Represents the possible states of the breakout game
    /// </summary>
    public enum GAME_STATE
    {
        /// <summary>
        /// Game is actively running
        /// </summary>
        ACTIVE,
        /// <summary>
        /// You lose
        /// </summary>
        GAME_OVER,
        /// <summary>
        /// Game is currently in the main menu
        /// </summary>
        MENU,
        /// <summary>
        /// Game is currently in the pause menu
        /// </summary>
        PAUSED,
        /// <summary>
        /// Game is awaiting user input to resume activity
        /// </summary>
        PENDING
    }
}

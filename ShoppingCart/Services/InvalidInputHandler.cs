using SC.UI.Services;
using System;

namespace ShoppingCart.Services
{
    public class InvalidInputHandler
    {
        public static void EraseInvalidInput(int serviceId = 0)
        {
            Console.SetCursorPosition(CursorHandler.CursorLeftPosition(serviceId), CursorHandler.CursorTopPosition(serviceId));
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(CursorHandler.CursorLeftPosition(serviceId), CursorHandler.CursorTopPosition(serviceId));
        }
    }
}

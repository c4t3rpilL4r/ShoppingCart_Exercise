using SC.BL.Manager;

namespace SC.UI.Services
{
    public class CursorHandler
    {
        public static int CursorTopPosition(int serviceId = 0)
        {
            CartManager cartManager = new CartManager();

            int top = 18;

            if (serviceId == -2)
            {
                top = 19;
            }
            else if (serviceId == -1)
            {
                top += 3;
            }
            else if (serviceId == 0)
            {
                top = 17;
            }

            if (cartManager.RetrieveAll().Count > 0)
            {
                top += 8 + cartManager.RetrieveAll().Count;
            }

            return top;
        }

        public static int CursorLeftPosition(int serviceId = 0)
        {
            int left;

            if (serviceId == -2)
            {
                left = 10;
            }
            else if (serviceId == -1)
            {
                left = 46;
            }
            else if(serviceId == 1)
            {
                left = 18;
            }
            else if (serviceId == 2)
            {
                left = 36;
            }
            else if (serviceId == 3)
            {
                left = 27;
            }
            else
            {
                left = 22;
            }

            return left;
        }
    }
}

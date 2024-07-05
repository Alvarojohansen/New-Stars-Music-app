import {
  Card,
  Input,
  Checkbox,
  Button,
  Typography,
} from "@material-tailwind/react";
import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import { useCart } from "../../hooks/useCart";
import { useTheme } from "../../services/contexts/ThemeProvider";
import toast from "react-hot-toast";

const Payment = () => {
  const [open, setOpen] = useState(false);
  const [address, setAddress] = useState("");
  const [apartment, setApartment] = useState("");
  const [country, setCountry] = useState("");
  const [city, setCity] = useState("");
  const [postalCode, setPostalCode] = useState("");
  const [phone, setPhone] = useState("");
  const [cardNumber, setCardNumber] = useState("");
  const [expirationDate, setExpirationDate] = useState("");
  const [cvv, setCvv] = useState("");
  const [isProcessingPayment, setIsProcessingPayment] = useState(false);
  const navigate = useNavigate();
  const { cartTotal } = useCart();

  const stateChangeHandler = (e, setState) => {
    setState(e.target.value);
  };
  const { theme } = useTheme();

  const delay = (ms) => new Promise((resolve) => setTimeout(resolve, ms));

  const makePaymentHandler = async () => {
    setIsProcessingPayment(true);
    toast.loading("Processing payment... Please wait", 3000);
    await delay(3000);
    toast.dismiss();
    toast.success("Your order was successfully made!");
  };

  return (
    <div className="ml-10 pt-4">
      <Typography variant="h2" className="font-light">
        Payment
      </Typography>
      <Typography variant="h3" className="mb-4 font-light">
        Total:{" "}
        <span className="text-orange-600">${cartTotal.toFixed(2)} ARS</span>
      </Typography>
      <div className="flex justify-center gap-16">
        <Card color="transparent" shadow={false}>
          <Typography
            variant="h4"
            className="font-light"
            color={theme ? "white" : "blue-gray"}
          >
            Where will you receive your order?
          </Typography>
          <Typography
            className={`mt-1 font-normal ${
              theme ? "text-gray-500" : "text-gray-600"
            }`}
          >
            This information will be saved for future purchases.
          </Typography>
          <form className="mt-8 mb-2 w-80 max-w-screen-lg sm:w-96">
            <div className="mb-1 flex flex-col gap-6">
              <Input
                color={theme && "white"}
                label="Country"
                size="md"
                value={country}
                onChange={() => stateChangeHandler(event, setCountry)}
              />
              <Input
                color={theme && "white"}
                label="City"
                size="md"
                value={city}
                onChange={() => stateChangeHandler(event, setCity)}
              />
              <Input
                color={theme && "white"}
                label="Postal Code"
                size="md"
                value={postalCode}
                onChange={() => stateChangeHandler(event, setPostalCode)}
              />
              <Input
                color={theme && "white"}
                label="Address"
                size="md"
                value={address}
                onChange={() => stateChangeHandler(event, setAddress)}
              />
              <Input
                color={theme && "white"}
                label="Apartment / Floor"
                size="md"
                value={apartment}
                onChange={() => stateChangeHandler(event, setApartment)}
              />
              <Input
                color={theme && "white"}
                label="Phone"
                size="md"
                value={phone}
                onChange={() => stateChangeHandler(event, setPhone)}
              />
            </div>
          </form>
        </Card>
        <Card color="transparent" shadow={false}>
          <Typography
            variant="h4"
            className="font-light"
            color={theme ? "white" : "blue-gray"}
          >
            Credit Card Information
          </Typography>
          <Typography
            color="gray"
            className={`mt-1 font-normal ${
              theme ? "text-gray-500" : "text-gray-600"
            }`}
          >
            This data is encrypted end-to-end.
          </Typography>
          <form className="mt-8 mb-2 w-80 max-w-screen-lg sm:w-96">
            <div className="mb-1 flex flex-col gap-6">
              <Input
                color={theme && "white"}
                label="Number"
                type="number"
                size="md"
                value={cardNumber}
                onChange={() => stateChangeHandler(event, setCardNumber)}
              />

              <Input
                type="date"
                color={theme && "white"}
                label="Expiration Date"
                size="md"
                value={expirationDate}
                onChange={() => stateChangeHandler(event, setExpirationDate)}
              />
              <Input
                color={theme && "white"}
                label="CVV"
                type="number"
                size="md"
                value={cvv}
                onChange={() => stateChangeHandler(event, setCvv)}
              />
            </div>
          </form>
        </Card>
      </div>
      <div className="flex justify-center">
        <Button
          disabled={isProcessingPayment ? true : false}
          color={theme && "white"}
          className="my-6 max-w-28"
          fullWidth
          onClick={makePaymentHandler}
        >
          Buy
        </Button>
      </div>
    </div>
  );
};

export default Payment;

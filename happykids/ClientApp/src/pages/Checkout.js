import React from "react";
import { Link } from "react-router-dom";
import { BiArrowBack } from "react-icons/bi";
import product from '../images/product1_2.png';
import Container from "../components/Container";
const Checkout = () => {
  return (
    <>
      <Container class1="checkout-wrapper py-5 home-wrapper-2">    
          <div className="row">
            <div className="col-7">
              <div className="checkout-left-data">
                <h3 className="website-name">LocKer Grow</h3>
                <nav
                  style={{ "--bs-breadcrumb-divider": ">" }}
                  aria-label="breadcrumb"
                >
                  <ol className="breadcrumb">
                    <li className="breadcrumb-item">
                      <Link className="text-dark total-price" to="cart">
                        Cart
                      </Link>
                    </li>
                    &nbsp; /  &nbsp;
                    <li className="breadcrumb-item total-price active" aria-current="page">
                      Information
                    </li>
                    &nbsp; /{" "}
                    <li className="breadcrumb-item total-price active">Shipping </li>
                    &nbsp; /
                    <li className="breadcrumb-item total-price active" aria-current="page">
                      Payment
                    </li>
                  </ol>
                </nav>
                <h4 className="title total">Contact Information</h4>
                <p className="user-details total">
                  name test@gmail.com
                </p>
                <h4 className="mb-3">Shipping</h4>
                <form
                  action=""
                  className="d-flex gap-15 flex-wrap justify-content-between"
                >
                  <div className="w-100">
                    <select name="" className="form-control form-select" id="">
                      <option value="" selected disabled>
                        select Country
                      </option>
                    </select>
                  </div>
                  <div className="flex-grow-1">
                    <input
                      type="text"
                      placeholder="First Name"
                      className="form-control"
                    />
                  </div>
                  <div className="flex-grow-1">
                    <input
                      type="text"
                      placeholder="Last Name"
                      className="form-control"
                    />
                  </div>
                  <div className="w-100">
                    <input
                      type="text"
                      placeholder="Address"
                      className="form-control"
                    />
                  </div>
                  <div className="w-100">
                    <input
                      type="text"
                      placeholder="Apartment, Sui"
                      className="form-control"
                    />
                  </div>
                  <div className="flex-grow-1">
                    <input
                      type="text"
                      placeholder="City"
                      className="form-control"
                    />
                  </div>
                  <div className="flex-grow-1">
                    <select name="" className="form-control form-select" id="">
                      {" "}
                      <option value="" selected disabled>
                        select State
                      </option>
                    </select>
                  </div>
                  <div className="flex-grow-1">
                    <input
                      type="text"
                      placeholder="Zipcode"
                      className="form-control"
                    />
                  </div>
                  <div className="w-100">
                    <div className="d-flex justify-content-between align-items-center">
                      <Link to="/cart" className="text-dark">
                        <BiArrowBack className="me-2" /> Return to Cart
                      </Link>
                      <Link to="/cart" className="button">
                        Continue to Shipping
                      </Link>
                    </div>
                  </div>
                </form>
              </div>
            </div>
            <div className="col-5">
              <div className="border-bottom py-4">
                <div className="d-flex gap-10 mb-2 align-items-center">
                  <div className="w-75 d-flex gap-10">
                    <div className="w-25 position-relative">
                      <span
                        style={{ top: "-10px", right: "2px" }}
                        className="bage bg-secondary text-white rounded-circle p-2 position-absolute"
                      >
                        1
                      </span>
                      <img className="img-fluid" src={product} alt="product" />
                    </div>
                    <div>
                      <h5 className="total-price">test</h5>
                      <p className="total-price"> test </p>
                    </div>
                  </div>
                  <div className="flex-grow-1">
                    <h5>199 bath</h5>
                  </div>
                </div>
              </div>
              <div className="border-bottom py-4">
                <div className="d-flex justify-content-between align-items-center">
                  <p className="total">SubTotal</p>
                  <p className="total-price"> 199 bath</p>
                </div>
                <div className="d-flex justify-content-between align-items-center">
                  <p className="mb-0 total">Shipping</p>
                  <p className="mb-0 total-price"> 0 Bath</p>
                </div>
              </div>
              <div className="d-flex justify-content-between align-items-center border-bottom py-4">
                <h4 className="total">Total</h4>
                <h5 className="total-price">199 bath</h5>
              </div>
            </div>
          </div>
        </Container>
    </>
  );
};

export default Checkout;

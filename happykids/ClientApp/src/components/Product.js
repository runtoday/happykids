import React, { Component } from 'react';
import {useParams} from 'react-router-dom';

function withParams(t) {
  return props => <t {...props} params={useParams()} />;
}

  class Product extends Component {

  constructor(props) {
    super(props);
    //const params = this.props.params;
    //console.log(params);
    //console.log(params);
    this.state={
        //value:this.props.location.state.id,
        Products: [], loading: true,
    }
  }


  async populateProduct(id) {
    //const response = await fetch('weatherforecast');
    //const Path = 'ProductDetail/1';
    
    const response = await fetch('ProductService/'+id);
    const data = await response.json();
    this.setState({ Products: data, loading: false });
  }

  componentDidMount() {
    //this.populateProduct(this.props.history.location.pathname.split("/").slice(-1)[0]);
    //console.log(this.props.match.params.id);
    //const [searchParams, setSearchParams] = useSearchParams();
   
    //console.log(searchParams.get("id"));
    const pid  = 1;
    this.populateProduct(pid);
  }


  /*static renderForecastsTable(forecasts) {
    return (
      <table className="table table-striped" aria-labelledby="tableLabel">
        <thead>
          <tr>
            <th>Date</th>
            <th>Temp. (C)</th>
            <th>Temp. (F)</th>
            <th>Summary</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map(forecast =>
            <tr key={forecast.date}>
              <td>{forecast.date}</td>
              <td>{forecast.temperatureC}</td>
              <td>{forecast.temperatureF}</td>
              <td>{forecast.summary}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }*/

  static renderProduct(products) {
    return (
<section>
<div class="product-card-view" >
{products.productColor.map(product =>
<div class="product-image-view" >
<span class="discount-tag">50% off</span>
<img src={"data:image/png;base64," + product.image} width={206} height={206} class="product-thumb" alt="" />
</div>)}
</div>
<div class="details">
     <h2 class="product-brand">calvin klein</h2>
     <p class="product-short-des">Lorem ipsum dolor sit, amet consectetur adipisicing elit.</p>
     <span class="product-price">$99</span>
     <span class="product-actual-price">$200</span>
     <span class="product-discount">( 50% off )</span>
     <p class="product-sub-heading">select size</p>
     <input type="radio" name="size" value="s" checked hidden id="s-size"/>
     <label for="s-size" class="size-radio-btn check">s</label>
     <input type="radio" name="size" value="m" hidden id="m-size" />
     <label for="m-size" class="size-radio-btn">m</label>
     <input type="radio" name="size" value="l" hidden id="l-size" />
     <label for="l-size" class="size-radio-btn">l</label>
     <input type="radio" name="size" value="xl" hidden id="xl-size" />
     <label for="xl-size" class="size-radio-btn">xl</label>
     <input type="radio" name="size" value="xxl" hidden id="xxl-size" />
     <label for="xxl-size" class="size-radio-btn">xxl</label>
     <button class="btn cart-btn">add to cart</button>
     <button class="btn">add to wishlist</button>
 </div>
 </section>
    );
  }

  render() {
    //this.setState({ id:GetOldState() })GetOldState;
    const pid  = this.props.params;
    console.log('hey id' +pid);
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Product.renderProduct(this.state.Products);
    return (
      <div>
        {contents}
      </div>
    );
  }

}

export default withParams(Product);
import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { forecasts: [], loading: true };
  }


  componentDidMount() {
    this.populateWeatherData();
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

  static renderForecastsTable(forecasts) {
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
            <tr key={forecast.productID}>
              <td>{forecast.name}</td>
              <td>{forecast.price}</td>
              <td> <img src ={"data:image/png;base64," + forecast.image} width={206} height={206}/></td>
              <td>{forecast.productID}</td>
            </tr>
          )}
        </tbody>
        
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderForecastsTable(this.state.forecasts);

    return (
      <div>
        <h1 id="tableLabel">Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateWeatherData() {
    //const response = await fetch('weatherforecast');
    const response = await fetch('ProductService');
    const data = await response.json();
    //var img = 'data:image/png;base64,'+ this.arrayBufferToBase64(data.image);
    this.setState({ forecasts: data, loading: false });
  }

  
}

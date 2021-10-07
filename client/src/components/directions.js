import React, { Component } from 'react';

export class Directions extends Component {
  static displayName = Directions.name;

  render() {
    return (
      <div>
        <img src="/images/Directions.PNG" alt="directions page"></img>
      </div>
    );
  }

  async populateWeatherData() {
    const response = await fetch('page');
    const data = await response.json();
    this.setState({ pages: data, loading: false });
  }
}

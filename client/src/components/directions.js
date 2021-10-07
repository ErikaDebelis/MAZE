import React, { Component } from 'react';

export class Directions extends Component {
  static displayName = Directions.name;

  render() {
    return (
      <div>
        <p className="textlight">click the door numbers on the page to change the page and move through the doors!</p>
        <img src="/images/Directions.PNG" alt="directions page"></img>
      </div>
    );
  }
}
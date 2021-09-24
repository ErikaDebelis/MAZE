import React from 'react';
import Page from './Page';

class PageControl extends React.Component {

  constructor(props) {
    super(props);
    this.state = {
      imageVisibleOnPage: false,
      textVisibleOnPage: false,
    };
  }

  render() {
    let currentlyVisibleState = null;
    if(this.state.imageVisibleOnPage) {
      currentlyVisibleState = <Page />
    }
    return (
      <React.Fragment>
        {currentlyVisibleState}
      </React.Fragment>
    );
  }
}

//idk taking a shot in the dark
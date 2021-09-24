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

  handleClick = () => {
    this.setState(prevState => ({imageVisibleOnPage: !prevState.imageVisibleOnPage}));
  }

  static async getApiData(pageId, text) {
    try {
      const response = await fetch(`https://5000/api/MAZE/{id}`);
      if (!response.ok) {
        throw Error(response.result);
      }
      return response.json();
    } catch (error) {
      return error;
    }
  }
}

  function handleApiCall(event) {
    event.preventDefault();
    const door = $("#area.title").val(); 
    // need to figure out how to grab page number from html image maps

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
import React, { Component } from 'react';

export class PageControl extends Component {

  constructor(props) {
    super(props);
    this.state = {
      error: null,
      isPageLoaded: false,
      page: null,
      pageId: 46
    };
  }

  handleClick = (event) => {
    event.preventDefault();
    const newPageId = parseInt(event.target.dataset.title)
    if (!isNaN(parseFloat(newPageId))) {
      this.setState({pageId: newPageId})
      this.handleChangingSelectedDoor();
    }
  }

  async handleChangingSelectedDoor() {
    const response = await fetch(`http://localhost:5000/api/pages/${this.state.pageId}`);
    const data = await response.json();
    this.setState({page: data, isPageLoaded: true });
  }

  translateImageMaps = () => {
    const imageMaps = this.state.page.doors;
    return{__html: imageMaps};
  }

  componentDidMount = () => {
    const element = document.querySelector(".mazin")
    element.addEventListener('click', this.handleClick)
    this.handleChangingSelectedDoor()
  }

  render() {
    console.log(this.state.page)
    return (
      <div className="mazin">
        {!this.state.isPageLoaded || !this.state.page ? (
          <div> loading...</div>
          ) : (
            <div>
            <div dangerouslySetInnerHTML={this.translateImageMaps()} />
            <div>{this.state.page.text}</div>
          </div>
        )}
      </div>
    );
  }
}
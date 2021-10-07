import React, { Component } from 'react';
import { withRouter } from "react-router";
import PropTypes from 'prop-types';
export class PageControl extends Component {

  constructor(props) {
    super(props);
    this.state = {
      error: null,
      isPageLoaded: false,
      page: null,
      pageId: 1
    };

  }

  handleClick = (event) => {
    event.preventDefault();
    const newPageId = parseInt(event.target.dataset.title)
    this.setState({pageId: newPageId})
    this.handleChangingSelectedDoor();
    console.log('is this handle clickin?', newPageId)
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
  
  // getPageIdFromUrl() {
  //   const url = window.location.href;
  //   let newPageNum = url.substring(url.lastIndexOf("/") + 1, url.length)
  //   return newPageNum;
  // }
  
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


  //   handleClick = () => {
    //     this.setState(prevState => ({imageVisibleOnPage: !prevState.imageVisibleOnPage}),prevState => ({textVisibleOnPage: !prevState.textVisibleOnPage}));
    //     this.makeApiCall();
    //   }


  // makeApiCall = (id) => {
  //   fetch(`https://5000/api/pages/${id}`)
  //     .then(response => response.json())
  //     .then(
  //       (jsonifiedResponse) => {
  //         this.setState({
  //           isTextLoaded: true,
  //           pageText: jsonifiedResponse.result.text
  //         });
  //       })
  //       .catch((error) => {
  //         this.setState({
  //           isTextLoaded: true,
  //           error
  //         });
  //       });
  // }
//   static async getApiData(pageId) {
//     try {
//       const response = await fetch(`https://5000/api/MAZE/${id}`);
//       if (!response.ok) {
//         throw Error(response.result);
//       }
//       return response.json();
//     } catch (error) {
//       return error;
//     }
//   }
// }


// function handleGettingTextForNewPage(response) {
//   if (response["result"] === "success") {
//     const newPageText = this.state(response.text);
//     this.setState({
//       currentPageText: newPageText,
//       textVisibleOnPage: false
//     });
//   }


//   function handleApiCall(event) {
//     event.preventDefault();
//     const pageId = $("#area.data-index").val();
//     // need to figure out how to grab page number from html image maps

import React, { Component } from 'react';
import { withRouter } from "react-router";

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

  // handleClick = (event) => {
  //   event.preventDefault();
  //   this.componentDidMount(uiPageId);
  // }

  // handleChangingSelectedDoor = (id) => {
  //   const selectedDoor = imageMaps.filter(page => page.pageId === id)[0];
  //   this.setState({
  //     selectedDoor: selectedDoor
  //   });
  // }

  translateImageMaps = () => {
    const imageMaps = this.state.page.doors;
    return{__html: imageMaps};
  }
  
  
  async componentDidMount(uiPageId) {
    if (uiPageId) {
    const response = await fetch(`http://localhost:5000/api/pages/${uiPageId}`);
    this.setState({pageId: uiPageId, isPageLoaded: true });
    } else {
      const response = await fetch(`http://localhost:5000/api/pages/${this.state.pageId}`);
      const data = await response.json();
      this.setState({page: data, isPageLoaded: true });
    }
    
  }
  
  render() {
    console.log(this.state.page)
    return (
      <div>
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

// async componentDidMount() {
//   const response = await fetch(`http://localhost:5000/api/pages/5`);
//   const data = await response.json();
//   this.setState({page: data[5], loading: false });
// }


// async getDefaultPageAsync() {
  //   const response = await fetch(`http://localhost:5000/api/pages/1`);
  //   return await response.json();
  // }
  
  
//     render() {
//       var page = this.getDefaultPageAsync()
//       var displayHtml = page.Doors;
//       var text = page.Text;

//       return (
//         <div>
//             <div>{text}</div>
//       </div>
//     );
//   }
// }





















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

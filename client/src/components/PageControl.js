import React, { Component } from 'react';

export class PageControl extends Component {

  constructor(props) {
    super(props);
    this.state = {
      error: null,
      isPageLoaded: false,
      page: null
    };
  }

  async componentDidMount() {
    const response = await fetch(`http://localhost:5000/api/pages/5`);
    const data = await response.json();
    this.setState({page: data, loading: false });
  }

  render() {
    return (
      <div>
        {this.state.loading || !this.state.page ? (
          <div> loading...</div>
        ) : (
          <div>
            <img src={this.state.page.img} />
            <div>{this.state.page.doors}</div>
            <div>{this.state.page.text}</div>
          </div>
        )}
      </div>
    );
  }
}







  // const imageMapPage = `pg{pageId}-image-map`;
  // const imageMaps = () => <div dangerouslySetInnerHTML={{ __html: imageMapPage }} />

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

import React from 'react';
import Page from './Page';

class PageControl extends React.Component {

  constructor(props) {
    super(props);
    this.state = {
      error: null,
      isTextLoaded: false,
      pageText: "",
      imageVisibleOnPage: false
    };
  }

const imageMapPage = `pg{pageId}-image-map`;
const imageMaps = () => <div dangerouslySetInnerHTML={{ __html: imageMapPage }} />

  handleClick = () => {
    this.setState(prevState => ({imageVisibleOnPage: !prevState.imageVisibleOnPage}),prevState => ({textVisibleOnPage: !prevState.textVisibleOnPage}));
    this.makeApiCall();
  }


  makeApiCall = (id) => {
    fetch(`https://5000/api/pages/${id}`)
      .then(response => response.json())
      .then(
        (jsonifiedResponse) => {
          this.setState({
            isTextLoaded: true,
            pageText: jsonifiedResponse.result.text
          });
        })
        .catch((error) => {
          this.setState({
            isTextLoaded: true,
            error
          });
        });
  }
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


function handleGettingTextForNewPage(response) {
  if (response["result"] === "success") {
    const newPageText = this.state(response.text);
    this.setState({
      currentPageText: newPageText,
      textVisibleOnPage: false
    });
  }


  function handleApiCall(event) {
    event.preventDefault();
    const pageId = $("#area.data-index").val(); 
    // need to figure out how to grab page number from html image maps
    
  }
  render() {
    const { error, isTextLoaded, page } = this.state;
    if (error) {
      return <React.Fragment>Error: {error.message}</React.Fragment>;
    } else if (!isTextLoaded) {
      return <React.Fragment>Loading...</React.Fragment>;
    } else {
      return (
        <React.Fragment>
          <h1>Text</h1>
          <p>{page.text}</p>
        </React.Fragment>
      );
    }
  }

//idk taking a shot in the dark



﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimServices
{
    public class claimantData
    {
        #region private data

        //Claimant Basic data
        private string _claimNumber;
        private string _firstName;
        private string _lastName;
        private string _status;
        private DateTime _lossDate;
        private long _adjusterId;

        //Private data for Loss Details
        private string _causeOfLoss;
        private DateTime _reportedDate;
        private string _lossDescription;

        //Private data for Vehicle Information
        private int _modelYear;
        private string _makeDescription;
        private string _modelDescription;
        private string _engineDescription;
        private string _exteriorColor;
        private string _vin;
        private string _licenePlate;
        private DateTime _licPlateExpDate;
        private string _damageDescription;
        private int _mileage;

        #endregion

        #region Gets or Sets the data
        /// <summary>Claim Number AutoGenerated.</summary>
        public string claimNumber
        {
            get { return _claimNumber; }
            set { _claimNumber = value; }
        }

        /// <summary>First Name of Claimant. Must be string.</summary>
        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        /// <summary>Last Name of Claimant. Must be String.</summary>
        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>Status of Case. Must be either Open or Close.</summary>
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>Loss Date. Must be dateTime.</summary>
        public DateTime lossDate
        {
            get { return _lossDate; }
            set { _lossDate = value; }
        }

        /// <summary>Adjuster's unique Id</summary>
        public long adjusterId
        {
            get { return _adjusterId; }
            set { _adjusterId = value; }
        }

        ///<summary>Gets or sets the Model Year of the vehicle.</summary>
        public int modelYear
        {
            get { return _modelYear; }
            set { _modelYear = value; }
        }

        ///<summary>Gets or sets the Make Description of the vehicle.</summary>
        public string makeDescription
        {
            get { return _makeDescription; }
            set { _makeDescription = value; }
        }

        ///<summary>Gets or sets the Model Description of the vehicle.</summary>
        public string modelDescription
        {
            get { return _modelDescription; }
            set { _modelDescription = value; }
        }

        ///<summary>Gets or sets the Engine Description of the vehicle.</summary>
        public string engineDescription
        {
            get { return _engineDescription; }
            set { _engineDescription = value; }
        }

        ///<summary>Gets or sets the Exterior color of the vehicle.</summary>
        public string exteriorColor
        {
            get { return _exteriorColor; }
            set { _exteriorColor = value; }
        }

        ///<summary>Gets or sets the VIN of the vehicle.</summary>
        public string vin
        {
            get { return _vin; }
            set { _vin = value; }
        }

        ///<summary>Gets or sets the license Plate of the vehicle.</summary>
        public string licensePlate
        {
            get { return _licenePlate; }
            set { _licenePlate = value; }
        }

        ///<summary>Gets or sets the Expiration date of the license plate of the vehicle.</summary>
        public DateTime licPlateExpDate
        {
            get { return _licPlateExpDate; }
            set { _licPlateExpDate = value; }
        }

        ///<summary>Gets or sets the Damage description of the vehicle.</summary>
        public string damageDescription
        {
            get { return _damageDescription; }
            set { _damageDescription = value; }
        }

        ///<summary>Gets or sets the mileage of the vehicle.///</summary>
        public int mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        ///<summary>Gets or sets the Cause of accident.</summary>
        public string causeOfLoss
        {
            get { return _causeOfLoss; }
            set { _causeOfLoss = value; }
        }

        ///<summary>Gets or sets the reported date of the accident.</summary>
        public DateTime reportedDate
        {
            get { return _reportedDate; }
            set { _reportedDate = value; }
        }

        ///<summary>Gets or sets the Loss Description.</summary>
        public string lossDescription
        {
            get { return _lossDescription; }
            set { _lossDescription = value; }
        }

        #endregion
    }
}

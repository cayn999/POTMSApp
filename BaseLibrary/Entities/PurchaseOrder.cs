﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
	public class PurchaseOrder : BaseEntity
	{
		public string? Division { get; set; }
        [Required, DataType(DataType.Text)]
        public string? Remarks { get; set; }

		public int RequestId { get; set; }
		public Request? Request { get; set; }
		public int OrderDeliveryId { get; set; }
		public OrderDelivery? OrderDelivery { get; set; }
		public int AccountingApprovalId { get; set; }
		public AccountingApproval? AccountingApproval { get; set; }
		public int InspectionId { get; set; }
		public Inspection? Inspection { get; set; }
		public int CoaId { get; set; }
		public Coa? Coa { get; set; }
	}
}
